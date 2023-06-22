using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
	[SerializeField] private Transform target;
	[SerializeField] private float height = 2f;
	[SerializeField] private float horizontalOffset = 5f;
	[SerializeField] private float speed;
	private Vector3 offset;
	
	private void Start()
	{
		offset = new Vector3(0, height, -horizontalOffset);
	}
	
	private void LateUpdate() 
	{
		transform.position = target.transform.position;// + new Vector3(0, height, -horizontalOffset);
		transform.rotation = target.transform.rotation;
		
		transform.LookAt(target);
		
		//float car_Move = Mathf.Abs(Vector3.Distance(this.transform.position, target.transform.position) * speed);
		//this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, car_Move * Time.deltaTime);
	}
}
