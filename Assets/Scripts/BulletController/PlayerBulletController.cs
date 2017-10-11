using System.Collections;
using System.Collections.Generic;
using Abstract;
using Interface;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerBulletController : BulletController
{
	public float LifeTime;

	public int BulletDamage;

	public bool Destoryable;
	
	// Use this for initialization
	public override void Start ()
	{
	}
	
	// Update is called once per frame
	public override void Update () {
		transform.Translate(Vector3.forward * Speed * Time.deltaTime);
		LifeTime -= Time.deltaTime;
		if(LifeTime <= 0) Destroy(gameObject);
	}
	
	public override void OnCollisionEnter(Collision other)
	{
//		if (other.gameObject.CompareTag("Bullet"))
//		{
//			if (other.gameObject.GetComponent<BulletController>().isDestoryable)
//			{
//				Destroy(gameObject);
//			}
//		}

		
		if (other.gameObject.CompareTag("Enemy"))
		{
			other.gameObject.GetComponent<IDamageable>().RecieveDamage(BulletDamage);
			Destroy(gameObject);
		}
	}
}
