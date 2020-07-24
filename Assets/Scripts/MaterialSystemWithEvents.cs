using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSystemWithEvents : MonoBehaviour {

	// Use this for initialization
	void Start () {

		PlayerPrefs.DeleteAll ();
		POIEvents.onPOIEnter += POIEvents_onPOIEnter;
		
	}
	
	private void POIEvents_onPOIEnter(string poiName){
	
		string materialKey = " Material: " + poiName;

		if (PlayerPrefs.GetInt(materialKey) == 1) 
			return;
		PlayerPrefs.SetInt (materialKey, 1);
		Debug.Log ("You've taken " + poiName);
	
	}
}
