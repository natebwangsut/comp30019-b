﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
	public float speed;
	public float lifeTime;

	public int bulletDamage;
	
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		lifeTime -= Time.deltaTime;
		if(lifeTime <= 0) Destroy(gameObject);
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			other.gameObject.GetComponent<EnemyHealth>().damangeEnemy(bulletDamage);
			Destroy(gameObject);
		}
	}
}
