using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable
{
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
			Destroy(gameObject);
			Debug.Log("Enemy health <= 0, removing enemy.");
		}
	}

	public void RecieveDamage(int damage)
	{
		currentHealth -= damage;
		Debug.Log("Enemy damaged, current health = " + currentHealth);
	}
}
