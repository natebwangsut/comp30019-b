using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchColourR : MonoBehaviour
{
	private GameObject player;
	private Renderer player_rend;
	private Color player_clr;
	private Button click_btn;

	private Color start_clr;
	private int colour_id;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find("Player");
		player_rend = player.GetComponent<Renderer>();
		player_clr = player_rend.material.color;
		start_clr = player_clr;
		colour_id = 0;
		
		click_btn = GetComponent<Button>();
		click_btn.onClick.AddListener(TaskOnClick);
	}

	void Update()
	{
		player_rend = player.GetComponent<Renderer>();
		if (player_rend.material.color.Equals(start_clr))
		{
			colour_id = 0;
		} else if (player_rend.material.color.Equals(Color.green))
		{
			colour_id = 1;
		} else if (player_rend.material.color.Equals(Color.yellow))
		{
			colour_id = 2;
		}
		else
		{
			colour_id = 3;
		}
	}

	void TaskOnClick()
	{

		const int BLUE = 0;
		const int GREEN = 1;
		const int YELLOW = 2;
		const int RED = 3;
		
		
		switch (colour_id)
		{
			case BLUE:
				player_rend.material.color = Color.green;
				colour_id = 1;
				break;
			case GREEN:
				player_rend.material.color = Color.yellow;
				colour_id = 2;
				break;
			case YELLOW:
				player_rend.material.color = Color.red;
				colour_id = 3;
				break;
			case RED:
				player_rend.material.color = start_clr;
				colour_id = 0;
				break;
			default:
				break;
		}
		
	}
	
	
	
}
