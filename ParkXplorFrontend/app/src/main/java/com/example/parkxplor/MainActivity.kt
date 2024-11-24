package com.example.parkxplor

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.material3.Surface
import androidx.compose.ui.Modifier
import androidx.navigation.NavType
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import androidx.navigation.navArgument
import com.example.parkxplor.BusinessAndApi.LoginAndRegistrationHandler
import com.example.parkxplor.pages.Login
import com.example.parkxplor.pages.OSMMapScreen
import com.example.parkxplor.pages.Registration
import com.example.parkxplor.pages.SelectedParking
import com.example.parkxplor.pages.StartingPage
import com.example.parkxplor.ui.theme.ParkXplorTheme
import org.osmdroid.util.GeoPoint

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            ParkXplorTheme {
                Surface(
                    modifier = Modifier.fillMaxSize(),
                ) {
                    val navController = rememberNavController()
                    val Handler = LoginAndRegistrationHandler(this)
                    NavHost(navController, startDestination = "entry") {
                        composable("registration") {
                            Registration ( onRegister = {username, email,password->Handler.handleRegistration(username,email,password,navController)} )
                        }
                        composable("login") {
                            Login(onLogin = {  email, password ->
                                Handler.handleLogin(email, password, navController)
                            })

                        }
                        composable("entry"){
                            StartingPage (
                                onLoginClick = {navController.navigate("login")},
                                onRegistrationClick = {navController.navigate("registration")}
                            )
                        }
                        composable("map") {
                            val carParkingLocations = listOf(
                                GeoPoint(45.8150, 15.9819), // Zagreb
                                GeoPoint(45.8030, 15.9999)  // Blizu Zagreba
                            )
                            OSMMapScreen(
                                parkingLocations = carParkingLocations,
                                onMarkerClick = { geoPoint ->
                                    // Navigacija na ekran s detaljima o markeru
                                    navController.navigate("selectedParking/${geoPoint.latitude}/${geoPoint.longitude}")
                                }
                            )
                        }
                        composable(
                            route = "selectedParking/{latitude}/{longitude}",
                            arguments = listOf(
                                navArgument("latitude") { type = NavType.FloatType },
                                navArgument("longitude") { type = NavType.FloatType  }
                            )
                        ) { backStackEntry ->
                            val latitude = backStackEntry.arguments?.getDouble("latitude") ?: 0.0
                            val longitude = backStackEntry.arguments?.getDouble("longitude") ?: 0.0

                            SelectedParking(latitude = latitude, longitude = longitude)
                        }
                    }
                }
            }
        }
    }
}
