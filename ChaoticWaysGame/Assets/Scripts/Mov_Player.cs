using UnityEngine;
using System.Collections;

public class Mov_Player : MonoBehaviour 
{
	string mov = "stop";
	float finPos;

	void Update () 
	{
		if (Input.GetButtonDown ("Fire1") && mov == "stop") 
		{
			mov = "left";
			finPos =  transform.position.x - 10;
		}
		if (Input.GetButtonDown ("Fire2") && mov == "stop") 
		{
			mov = "right";
			finPos =  transform.position.x + 10;
		}
		transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+25*Time.deltaTime);
		
		if(mov == "right")
		{
			transform.position = new Vector3(transform.position.x+25*Time.deltaTime,transform.position.y,transform.position.z);
			if(transform.position.x >= finPos)
			{
				mov = "stop";
			}
		}
		if(mov == "left")
		{
			transform.position = new Vector3(transform.position.x-25*Time.deltaTime,transform.position.y,transform.position.z);
			if(transform.position.x <= finPos)
			{
				mov = "stop";
			}
		}
	}
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "la")
		{
			mov = "stop";
			transform.position = new Vector3(12,2,4);
		}
	}
	
}
