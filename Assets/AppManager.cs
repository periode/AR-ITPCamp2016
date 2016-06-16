using UnityEngine;
using System.Collections;

public class AppManager : MonoBehaviour {

	public bool isTracked = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isTracked)
			Debug.Log ("we know if something is being tracked!");
	}
}
