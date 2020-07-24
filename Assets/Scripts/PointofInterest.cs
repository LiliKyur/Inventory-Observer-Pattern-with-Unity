using UnityEngine;

public class PointofInterest : Subject {

	[SerializeField]
	private string poiName;

	private void OnTriggerEnter(Collider col)
	{
		Notify (poiName, NotificationType.ObjectTaken);
	}
}
