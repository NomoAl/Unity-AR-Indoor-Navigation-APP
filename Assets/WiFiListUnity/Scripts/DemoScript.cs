using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace BrainCheck {

	public enum WiFiListOptions 
	{
	  setUpPlugin,
	  getWifiList,
	  isWifiConnected,
	  isInternetConnectedvViaWifi,
	  isInternetConnected,
	  isInternetConnectedvViaMobile,
	  scanForWifiList,
	  checkWifiPermissions,
	  requestWifiPermissions,
	  // wifiEnable,
	  // wifiDisable,
	  // wifiConnect,
	  // wifiDisconnect,
	  // connectToWifi,
	  openWifiPage
	}

	public class DemoScript : MonoBehaviour
	{
		public WiFiListOptions myOption;
		string gameObjectName = "UnityReceiveMessage";
		string methodName = "CurrentStatus";

		void OnMouseUp() {
	    	StartCoroutine(BtnAnimation());
	 	}

	 	private IEnumerator BtnAnimation()
	    {
	    	Vector3 originalScale = gameObject.transform.localScale;
	        gameObject.transform.localScale = 0.9f * gameObject.transform.localScale;
	        yield return new WaitForSeconds(0.2f);
	        gameObject.transform.localScale = originalScale;
	        ButtonAction();
	    }

	    private void ButtonAction() {
	    	BrainCheck.WiFiManagerBridge.SetUnityGameObjectNameAndMethodName(gameObjectName, methodName);
	    	UnityReceiveMessages.Instance.CurrentStatus("");
			switch(myOption) 
			{
				case WiFiListOptions.checkWifiPermissions:
				  if (BrainCheck.WiFiManagerBridge.checkWifiPermissions()) {
				  	UnityReceiveMessages.Instance.CurrentStatus("WiFi Permissions Granted");
				  } else {
				  	UnityReceiveMessages.Instance.CurrentStatus("WiFi Permissions Not Granted");
				  }
			      break;
			    case WiFiListOptions.requestWifiPermissions:
				  BrainCheck.WiFiManagerBridge.requestWifiPermissions();
			      break;
				case WiFiListOptions.setUpPlugin:
				  BrainCheck.WiFiManagerBridge.setUpPlugin();
			      break;
			    case WiFiListOptions.scanForWifiList:
				  BrainCheck.WiFiManagerBridge.startWiFiScan();
			      break;
				case WiFiListOptions.getWifiList:
				  BrainCheck.WiFiManagerBridge.getWifiList();
			      break;
				case WiFiListOptions.isWifiConnected:
				  if (BrainCheck.WiFiManagerBridge.isWifiConnected()) {
				  	UnityReceiveMessages.Instance.CurrentStatus("WiFi Connected");
				  } else {
				  	UnityReceiveMessages.Instance.CurrentStatus("WiFi Not Connected");
				  }
			      break;
			    case WiFiListOptions.isInternetConnectedvViaWifi:
			      if (BrainCheck.WiFiManagerBridge.isInternetConnectedvViaWifi()) {
				  	UnityReceiveMessages.Instance.CurrentStatus("Internet Connected via WiFi");
				  } else {
				  	UnityReceiveMessages.Instance.CurrentStatus("Internet not Connected via WiFi");
				  }
			      break;
			    case WiFiListOptions.isInternetConnected:
			      if (BrainCheck.WiFiManagerBridge.isInternetConnected()) {
				  	UnityReceiveMessages.Instance.CurrentStatus("Internet Connected");
				  } else {
				  	UnityReceiveMessages.Instance.CurrentStatus("Internet not Connected");
				  }
			      break;
			    case WiFiListOptions.isInternetConnectedvViaMobile:
			      if (BrainCheck.WiFiManagerBridge.isInternetConnectedvViaMobile()) {
				  	UnityReceiveMessages.Instance.CurrentStatus("Internet Connected via Mobile");
				  } else {
				  	UnityReceiveMessages.Instance.CurrentStatus("Internet not Connected via Mobile");
				  }
			      break;
			    // case WiFiListOptions.wifiEnable:
				//   BrainCheck.WiFiManagerBridge.wifiEnable();
			    //   break;
				// case WiFiListOptions.wifiDisable:
				//   BrainCheck.WiFiManagerBridge.wifiDisable();
			    //   break;
			    // case WiFiListOptions.wifiConnect:
				//   BrainCheck.WiFiManagerBridge.wifiConnect();
			    //   break;
				// case WiFiListOptions.wifiDisconnect:
				//   BrainCheck.WiFiManagerBridge.wifiDisconnect();
			    //   break;
			    // case WiFiListOptions.connectToWifi:
				//   BrainCheck.WiFiManagerBridge.connectToWifi(4, "9416337907");
			    //   break;
			    case WiFiListOptions.openWifiPage:
				  BrainCheck.WiFiManagerBridge.openWifiPage();
			      break;
			}
	    }
	}
}
