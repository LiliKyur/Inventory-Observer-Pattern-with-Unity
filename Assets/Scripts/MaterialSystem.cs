using UnityEngine;

public class MaterialSystem : Observer {


	private void Start () {
		PlayerPrefs.DeleteAll();

		foreach (var poi in FindObjectsOfType<PointofInterest>()) {
			poi.RegisterObserver(this);
		}
		
	}

	public override void OnNotify(object value,NotificationType notificationType){

		if (notificationType == NotificationType.ObjectTaken) {
			string materialKey = " You Unlocked - " + value;
			if (PlayerPrefs.GetInt(materialKey) == 1) {
				return;

				PlayerPrefs.SetInt (materialKey, 1);
				Debug.Log ("Material " + value);
			}
		}
	
	}
}


public enum NotificationType{

	ObjectTaken
}

