package com.example.parkxplor.pages


import androidx.compose.foundation.layout.Arrangement


import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding


import androidx.compose.material3.Text


import androidx.compose.runtime.Composable

import androidx.compose.ui.Modifier


import androidx.compose.ui.unit.dp


@Composable
fun SelectedParking(latitude: Double, longitude: Double) {
    Column(
        modifier = Modifier
            .fillMaxSize()
            .padding(16.dp),
        verticalArrangement = Arrangement.Center
    ) {
        Text(text = "Podaci o odabranom parkiralištu:")
        Spacer(modifier = Modifier.height(8.dp))
        Text(text = "Latitude: $latitude")
        Text(text = "Longitude: $longitude")
    }
}
