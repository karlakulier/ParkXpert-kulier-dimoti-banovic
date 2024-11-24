package com.example.parkxplor.BusinessAndApi

import android.widget.Toast
import okhttp3.FormBody
import okhttp3.MediaType.Companion.toMediaType
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody
import okhttp3.RequestBody.Companion.toRequestBody
import org.json.JSONObject
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response
import java.io.IOException

class LoginAndRegistrationApi {
    fun loginUser(email: String, password: String, onResult: (Boolean, String?) -> Unit) {
        val url = "http://192.168.232.183:5044/api/User/login?email=${email}&password=${password}"

        val request = Request.Builder()
            .url(url) // Dodajemo URL s parametrima
            .post(RequestBody.create(null, "")) // Pražnjeno tijelo zahtjeva
            .build()

        // Kreiranje OkHttp klijenta
        val client = OkHttpClient()

        // Pokretanje zahtjeva asinkrono
        client.newCall(request).enqueue(object : okhttp3.Callback {
            override fun onFailure(call: okhttp3.Call, e: IOException) {
                e.printStackTrace()
                onResult(false, "Network error or request failed")  // U slučaju greške u mreži
            }

            override fun onResponse(call: okhttp3.Call, response: okhttp3.Response) {
                if (response.isSuccessful) {
                    val responseBody = response.body?.string()

                    // Parsiranje JSON odgovora
                    val jsonObject = JSONObject(responseBody ?: "")
                    val message = jsonObject.optString("message")
                    val username = jsonObject.optString("username")
                    val role = jsonObject.optString("role")

                    onResult(true, "Login successful: $message (User: $username, Role: $role)")
                } else {
                    val errorBody = response.body?.string()
                    onResult(false, errorBody ?: "Error occurred")
                }
            }
        })
    }

    fun registerUser(
        username: String,
        email: String,
        passwordHash: String,
        onResult: (Boolean, String?) -> Unit
    ) {
        // JSON podaci
        val json = """
            {
                "id": 0,
                "username": "$username",
                "email": "$email",
                "passwordHash": "$passwordHash",
                "role": "obican"
            }
        """.trimIndent()

        // Kreiranje tijela zahtjeva s JSON podacima
        val requestBody = json.toRequestBody("application/json; charset=utf-8".toMediaType())

        // URL endpoint
        val url = "http://192.168.232.183:5044/api/User/register"

        // Izgradnja zahtjeva
        val request = Request.Builder()
            .url(url)
            .post(requestBody) // POST metoda s JSON tijelom
            .addHeader("Content-Type", "application/json") // Header za JSON
            .addHeader("accept", "*/*") // Accept header
            .build()

        // Kreiranje OkHttp klijenta
        val client = OkHttpClient()

        // Pokretanje zahtjeva
        client.newCall(request).enqueue(object : okhttp3.Callback {
            override fun onFailure(call: okhttp3.Call, e: IOException) {
                e.printStackTrace()
                onResult(false, "Network error or request failed")
            }

            override fun onResponse(call: okhttp3.Call, response: okhttp3.Response) {
                if (response.isSuccessful) {
                    val responseBody = response.body?.string()
                    onResult(true, responseBody)
                } else {
                    onResult(false, response.message)
                }
            }
        })
    }
}

