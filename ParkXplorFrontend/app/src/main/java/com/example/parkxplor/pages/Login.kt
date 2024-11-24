package com.example.parkxplor.pages

import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.background

import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button

import androidx.compose.material3.Text
import androidx.compose.material3.TextField

import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember

import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color

import androidx.compose.ui.unit.dp
import androidx.compose.runtime.getValue
import androidx.compose.runtime.setValue
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import com.example.parkxplor.R


@Composable
fun Login(onLogin: (String, String) -> Unit) {
    var email by remember { mutableStateOf("") }
    var password by remember { mutableStateOf("") }
    val context = LocalContext.current

    Box(
        modifier = Modifier
            .fillMaxSize()
            .background(Color.Black),
        contentAlignment = Alignment.Center
    ) {
        Column(
            modifier = Modifier.padding(16.dp),
            horizontalAlignment = Alignment.CenterHorizontally
        ) {
            Image(
                painter = painterResource(id = R.drawable.pnglogo),
                contentDescription = "Logo"
            )
            Spacer(modifier = Modifier.height(32.dp))
            TextField(
                value = email,
                onValueChange = { email = it },
                label = { Text("Email") },

            )
            Spacer(modifier = Modifier.height(8.dp))
            TextField(
                value = password,
                onValueChange = { password = it },
                label = { Text("Password") }
            )
            Spacer(modifier = Modifier.height(16.dp))
            Button(
                onClick = {
                    if (email.isBlank() || password.isBlank()) {
                        // Prikaz poruke greške
                        Toast.makeText(context, "Email and password cannot be empty", Toast.LENGTH_SHORT).show()
                    } else {
                        onLogin(email, password)
                    }
                },
            ) {
                Text(text = "Sign in", color = Color.Black)
            }
        }
    }
}



