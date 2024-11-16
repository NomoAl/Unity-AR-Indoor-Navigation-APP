using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace BrainCheck {

	public class WiFiManagerBridge {
	    static AndroidJavaClass _class;
		static AndroidJavaObject instance { get { return _class.GetStatic<AndroidJavaObject>("instance"); } }

		private static void SetupPlugin () {
			if (_class == null) {
				_class = new AndroidJavaClass ("mayankgupta.com.audioPlugin.WifiListPlugin");
				_class.CallStatic ("_initiateFragment");
			}
		}

		public static void setUpPlugin(){
			SetupPlugin ();
		   	instance.Call("setUpPlugin");
		}

		public static bool checkWifiPermissions(){
			SetupPlugin ();
		   	return instance.Call<bool>("checkWifiPermission");
		}

		public static void requestWifiPermissions(){
			SetupPlugin ();
		   	instance.Call("requestWifiPermission");
		}

		public static void startWiFiScan(){
			SetupPlugin ();
		   	instance.Call("startWiFiScan");
		}

		public static void getWifiList(){
			SetupPlugin ();
		   	instance.Call("getListOfWiFiAvailable");
		}

		public static bool isInternetConnected() {
			SetupPlugin ();
			return instance.Call<bool>("isInternetConnected");
		}

		public static bool isWifiConnected() {
			SetupPlugin ();
			return instance.Call<bool>("isWifiConnected");
		}

		public static bool isInternetConnectedvViaWifi() {
			SetupPlugin ();
			return instance.Call<bool>("isInternetConnectedViaWiFi");
		}

		public static bool isInternetConnectedvViaMobile() {
			SetupPlugin ();
			return instance.Call<bool>("isInternetConnectedViaMobileNetwork");
		}


		public static void SetUnityGameObjectNameAndMethodName(string ganeObject, string methodName){
			SetupPlugin ();
		   	instance.Call("_setUnityGameObjectNameAndMethodName", ganeObject, methodName);
		}

		public static void wifiEnable() {
			SetupPlugin ();
			instance.Call("wifiEnable");
		}

		public static void wifiDisable() {
			SetupPlugin ();
			instance.Call("wifiDisable");
		}

		public static void wifiConnect() {
			SetupPlugin ();
			instance.Call("wifiConnect");
		}


		public static void wifiDisconnect(){
			SetupPlugin ();
		   	instance.Call("wifiDisconnect");
		}

		public static void connectToWifi(int index, string password){
			SetupPlugin ();
		   	instance.Call("connectToWifi", index, password);
		}

		public static void openWifiPage() {
			SetupPlugin ();
			instance.Call("openWifiPage");
		}
	}

}