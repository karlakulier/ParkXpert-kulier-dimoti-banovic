package com.example.parkxplor.BusinessAndApi

import android.app.Activity
import android.widget.Toast
import androidx.navigation.NavController

class LoginAndRegistrationHandler(private val activity: Activity) {
    fun handleLogin(email: String, password: String, navController: NavController) {
        val repository = LoginAndRegistrationApi()

        repository.loginUser(email, password) { success, message ->
            activity.runOnUiThread {
                if (success) {
                    // Navigacija na home ekran
                    Toast.makeText(activity, "Login successful!", Toast.LENGTH_SHORT).show()
                    navController.navigate("map")
                } else {
                    // Prikaz greške
                    Toast.makeText(
                        activity,
                        message ?: "Login failed. Please try again.",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            }
        }
    }

    fun handleRegistration(username: String,
                           email: String,
                           password: String,

                           navController: NavController) {
        val repository = LoginAndRegistrationApi()

        repository.registerUser(username,email, password) { success, message ->
            activity.runOnUiThread {
                if (success) {
                    // Navigacija na home ekran
                    Toast.makeText(activity, "Registration successful!", Toast.LENGTH_SHORT).show()
                    navController.navigate("login")
                } else {
                    // Prikaz greške
                    Toast.makeText(
                        activity,
                        message ?: "Registration failed. Please try again.",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            }
        }
    }
}