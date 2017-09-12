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
		Vector3 moveRotation = new Vector3(0, Input.GetAxis("Mouse X"), 0);
		moveRotation *= rotationSpeed;
		transform.Rotate(moveRotation);
	}

}
