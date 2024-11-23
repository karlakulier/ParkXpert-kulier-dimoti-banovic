using ParkXplore.Core.Entities;
using ParkXplore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Application.Services {
    public class UserService : IUserService {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserByIdAsync(int userId) {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync() {
            return await _userRepository.GetAllAsync();
        }

        public async Task<bool> CreateUserAsync(User user) {
            
            user.PasswordHash = HashPassword(user.PasswordHash!);
            await _userRepository.AddAsync(user); 
            return await _userRepository.SaveChangesAsync();
        }

        public async Task<bool> UpdateUserAsync(User user) {
            _userRepository.Update(user);
            return await _userRepository.SaveChangesAsync();
        }

        public async Task<bool> DeleteUserAsync(int userId) {          
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) return false;

            _userRepository.Remove(user);
            return await _userRepository.SaveChangesAsync();
        }

        public async Task<User?> LoginAsync(string email, string password) {
            var user = await _userRepository.GetByEmailAsync(email);


            if (user == null || !VerifyPassword(password, user.PasswordHash))
                return null;

            return user;
        }

        private string HashPassword(string password) {
            using var sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        private bool VerifyPassword(string password, string? storedHash) {
            if (string.IsNullOrEmpty(storedHash)) return false;

            using var sha256 = SHA256.Create();
            var hashedPassword = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
            return hashedPassword == storedHash;
        }
    }
}

