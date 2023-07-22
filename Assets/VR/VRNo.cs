using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
public class VRNo : MonoBehaviour {
	
	// Use this for initialization
	public void Start () {
		StartCoroutine (DeactivatorVR ("none"));
	}

	public IEnumerator DeactivatorVR(string NOVR)
	{
		UnityEngine.XR.XRSettings.LoadDeviceByName(NOVR); 
		yield return null;
		UnityEngine.XR.XRSettings.enabled = false;
	}



}
