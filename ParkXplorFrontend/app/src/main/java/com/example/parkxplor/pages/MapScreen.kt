package com.example.parkxplor.pages

import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.runtime.Composable
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.viewinterop.AndroidView

import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker
import org.osmdroid.tileprovider.tilesource.TileSourceFactory
import org.osmdroid.util.GeoPoint


@Composable
fun OSMMapScreen(
    parkingLocations: List<GeoPoint>,
    onMarkerClick: (GeoPoint) -> Unit // Callback za klik na marker
) {
    val context = LocalContext.current
    val mapView = remember { MapView(context) }

    AndroidView(
        factory = { mapView },
        modifier = Modifier.fillMaxSize()
    ) { map ->
        // Postavljanje osnovnih postavki karte
        map.setTileSource(TileSourceFactory.OpenTopo)
        map.controller.setZoom(15.0)
        map.controller.setCenter(parkingLocations.firstOrNull() ?: GeoPoint(
            45.8150,
            15.9819
        )
        )


        // Dodavanje markera
        parkingLocations.forEach { location ->
            val marker = Marker(map).apply {
                position = location
                setAnchor(Marker.ANCHOR_CENTER, Marker.ANCHOR_BOTTOM)
                title = "Parking na ${location.latitude}, ${location.longitude}"
                setOnMarkerClickListener { _, _ ->
                    onMarkerClick(location)
                    true // Klik je obrađen
                }
            }
            map.overlays.add(marker)
        }
    }
}



