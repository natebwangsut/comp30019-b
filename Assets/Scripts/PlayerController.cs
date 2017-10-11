using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal.Commands;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
	[Header("Player")]
	public GunController Gun;
	public float MovementSpeed;
	[HideInInspector] public float RotationSpeed;

	private CharacterController _controller;
	private Rigidbody _rigidbody;

	private Vector3 moveDirection;
	
	// Use this for initialization
	void Start () {
		_controller = GetComponent<CharacterController>();
		_rigidbody = GetComponent<Rigidbody>();

		// Set movement speed if unset
		if (MovementSpeed <= 0) MovementSpeed = 5;
		RotationSpeed = MovementSpeed / 10;
		
		// Initiate position
		transform.position = Vector3.up * 5;
		transform.rotation = Quaternion.Euler(Vector3.zero);
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		Rotate();
		Fire();
	}

	void Move()
	{
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		
		if (_controller.isGrounded == false)
		{
			// Add gravity into Vector component
			moveDirection += Physics.gravity;
		}
		
		// Moving globally
		moveDirection *= MovementSpeed;
		_controller.Move(moveDirection * Time.deltaTime);
	}

	void Rotate()
	{
		var mouse = Input.mousePosition;
		var screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
		var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
		var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, -angle + 90, 0);
	}

	void Fire()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			Gun.isFiring = true;
		if (Input.GetKeyUp(KeyCode.Space))
			Gun.isFiring = false;
	}

}
