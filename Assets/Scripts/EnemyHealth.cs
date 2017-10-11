using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
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

	public void damageEnemy(int damage)
	{
		currentHealth -= damage;
		Debug.Log("Enemy damaged, current health = ." + currentHealth);
	}
}
