﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
	public bool isFiring;
	public BulletController Bullet;

	public float bulletSpeed;
	public float cooldown;

	private float shotCounter;

	public Transform firePoint;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (isFiring)
		{
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0)
			{
				shotCounter = cooldown;
				BulletController newBullet = Instantiate(Bullet, firePoint.position, firePoint.rotation);
				newBullet.Speed = Bullet.Speed;
			}
		}
		else
		{
			// If shotCounter > 0, -= Time.deltaTime, else = 0
			shotCounter = shotCounter > 0
				? shotCounter - Time.deltaTime
				: 0;
		}
	}
}