using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{


	public bool isStart;

	public bool isQuit;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseUp()
	{
		if (isStart)
		{
			Application.LoadLevel("gameplay");
		}

		if (isQuit)
		{
			Application.Quit();
			
			/* Line below to test if this portion of code works
			   because application would not "quit" in Unity */
			GetComponent<Renderer>().material.color = Color.cyan;

		}
	}
}
