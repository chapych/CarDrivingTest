using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
	private Rigidbody rigidbody;
	[SerializeField] private float power;
	
	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}
	public void MoveForward()
	{
		Vector3 direction = new Vector3(0,0,1);
		MoveIn(direction);
	}
	
	public void MoveBack()
	{
		Vector3 direction = new Vector3(0,0,-1);
		MoveIn(direction);
	}
	
	public void MoveRight()
	{
		Vector3 direction = new Vector3(0,1,0);
		Turn(direction);
	}
	public void MoveLeft()
	{
		Vector3 direction = new Vector3(0,-1,0);
		Turn(direction);
	}
	
	private void MoveIn(Vector3 direction)
	{
		rigidbody.AddRelativeForce(power * direction);
	}
	
	private void Turn(Vector3 direction)
	{
		rigidbody.AddTorque(power * direction);
	}
}
