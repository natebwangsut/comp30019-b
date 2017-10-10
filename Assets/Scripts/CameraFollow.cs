using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public GameObject target;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		if (offset == Vector3.zero)
			offset = (Vector3.up * 15);
	}
	
	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = target.transform.position + offset;
	}
}
