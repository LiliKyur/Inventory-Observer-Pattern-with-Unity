using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour {

	public abstract void OnNotify (object value, NotificationType notificationType);
}
public abstract class Subject : MonoBehaviour {

	private List<Observer> _observer = new List<Observer> ();

	public void RegisterObserver(Observer observer){
	
		_observer.Add(observer);
	}

	public void Notify(object value, NotificationType notificationType ){
		foreach (var observer in _observer) {
			observer.OnNotify (value, notificationType);
		}
	}
}
