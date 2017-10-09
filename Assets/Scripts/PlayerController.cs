using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal.Commands;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float movementSpeed;
	public float rotationSpeed;

	private float gravity = 9.81f;

	private CharacterController _controller;
	private Rigidbody _rigidbody;

	public GunController gun;
	
	// Use this for initialization
	void Start () {
		_controller = GetComponent<CharacterController>();
		_rigidbody = GetComponent<Rigidbody>();
		
		
		movementSpeed = 5;
		rotationSpeed = movementSpeed * 10;
		
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
		Vector3 moveDirection = Vector3.zero;
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		
		if (_controller.isGrounded == false)
		{
			// Add gravity into Vector component
			moveDirection += Physics.gravity;
		}
		
		// Moving globally
		//moveDirection = transform.TransformDirection(moveDirection); 
		moveDirection *= movementSpeed;
		_controller.Move(moveDirection * Time.deltaTime);
	}

	void Rotate()
	{
//		Vector3 moveRotation = new Vector3(0, Input.GetAxis("Mouse X"), 0);
//		moveRotation *= rotationSpeed;
//		transform.Rotate(moveRotation);
		
		var mouse = Input.mousePosition;
		var screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
		var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
		var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, -angle + 90, 0);
	}

	void Fire()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			gun.isFiring = true;
		if (Input.GetKeyUp(KeyCode.Space))
			gun.isFiring = false;
	}

}
