package com.example.parkxplor.pages

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.parkxplor.R
import com.example.parkxplor.ui.theme.ParkXplorTheme


@Composable
fun StartingPage(onLoginClick: () -> Unit,onRegistrationClick: () -> Unit) {
    Box(
        modifier = Modifier
            .fillMaxSize()
            .background(Color.Black),
        contentAlignment = Alignment.Center
    ) {
        Column(
            horizontalAlignment = Alignment.CenterHorizontally
        ) {
            Image(
                painter = painterResource(id = R.drawable.pnglogo),
                contentDescription = "Logo"
            )
            Spacer(modifier = Modifier.height(32.dp))
            Button(
                onClick = onRegistrationClick,

            ) {
                Text(text = "Let's Get Started", color = Color.Black)
            }
            Spacer(modifier = Modifier.height(8.dp))
            Text(
                text = "Already have an account? Sign in",
                color = Color.Yellow,
                modifier = Modifier.clickable(onClick = onLoginClick)
            )
        }
    }
}