using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace BrainCheck {

	public class UnityReceiveMessages : MonoBehaviour
	{
	    public static UnityReceiveMessages Instance;
	    public TextMesh tMesh;
		string currentStatus;
		string duration;
		void Awake(){
			Instance = this;	
		}

		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {
		
		}

		public void CurrentStatus(string currentStatusTemp){
			currentStatus = currentStatusTemp;
			tMesh.text = currentStatusTemp;
			// AudioPlayerCallbackHandling(currentStatus);
		}

		public void PlayerDuration(string durationTemp){
			duration = durationTemp;
		}

		public string CurrentStatusGetter() {
			return "Current Status === "+currentStatus;
		}

		public string GetDuration() {
			return "Duration === "+duration;
		}

		private void AudioPlayerCallbackHandling(string status) {
			print("===Audio Player Callbck=="+status);

			switch (status) {
	        case "AudioVisualizerSetUpComplete":
	            break;

	        default:
	            break;
	        }
			
		}
	}
}
