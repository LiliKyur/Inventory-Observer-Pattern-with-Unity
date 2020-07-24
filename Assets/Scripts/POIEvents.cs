using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class POIEvents : MonoBehaviour {

	public static Action<string> onPOIEnter;

	[SerializeField]
	private string _poiName;

	public string PoiName{get { return _poiName; } }

	private void OnTriggerEnter(Collider col){
	
		if (onPOIEnter != null) {
			onPOIEnter (this.PoiName);
		}
	
	}

}
