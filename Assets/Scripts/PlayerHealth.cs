using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int health;
	[HideInInspector]
	private int currentHealth;
	
	// Use this for initialization
	void Start ()
	{
		currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0)
		{
			// Player's Health = 0, gameover
		}
	}

	public void damangeEnemy(int damage)
	{
		currentHealth -= damage;
	}
}
