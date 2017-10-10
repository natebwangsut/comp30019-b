using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

	private Rigidbody _rigidbody;

	[Header("Enemy Properties")]
	public float moveSpeed;

	[Header("Automatically find player")]
	public PlayerController player;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = this.GetComponent<Rigidbody>();
		player = FindObjectOfType<PlayerController>();
	}
	
	void FixedUpdate()
	{
		_rigidbody.velocity = (transform.forward * moveSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform);
	}
}
