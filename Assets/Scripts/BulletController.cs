using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletController : MonoBehaviour
{
	public abstract void Start();
	public abstract void Update();
	public abstract void OnCollisionEnter(Collision other);

	public int Speed { get; set; }
}