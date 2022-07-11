using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour 
{
	private float horizontalInput;
	private float verticalInput;

	public float moveSpeed = 10f;
	public float turnSpeed = 5f;

	public Joystick joystick;
	
	void Start () 
	{
		
	}
	
	
	void Update ()
	{
		
		PlayerMove();
	}


	public void PlayerMove()
    {
		//horizontalInput = Input.GetAxisRaw("Horizontal1");   (Code for Keyboard horizontal control)
		horizontalInput = joystick.Horizontal;
		transform.Rotate(new Vector3(0, 10, 0) *horizontalInput* turnSpeed * Time.deltaTime);

		//verticalInput = Input.GetAxisRaw("Vertical1");    (code for Keyboard vertical control)
		verticalInput = joystick.Vertical;
		transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
		
    }
}
