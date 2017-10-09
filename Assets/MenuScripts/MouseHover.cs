using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseHover : MonoBehaviour
{
	private Renderer rend;

	// Use this for initialization
	void Start ()
	{

		rend = GetComponent<Renderer>();
		rend.material.color = Color.black;

	}


	private void OnMouseEnter()
	{
		rend.material.color = Color.yellow;
	}

	private void OnMouseExit()
	{
		rend.material.color = Color.black;
	}

	// Update is called once per frame
	void Update () {
		
	}

}
