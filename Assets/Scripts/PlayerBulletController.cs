using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerBulletController : BulletController
{
	public float speed;
	public float lifeTime;

	public int bulletDamage;

	public bool isDestoryable;
	
	// Use this for initialization
	public override void Start ()
	{
	}
	
	// Update is called once per frame
	public override void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		lifeTime -= Time.deltaTime;
		if(lifeTime <= 0) Destroy(gameObject);
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
			other.gameObject.GetComponent<EnemyHealth>().damageEnemy(bulletDamage);
			Destroy(gameObject);
		}
	}
}
