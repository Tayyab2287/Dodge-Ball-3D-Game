using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour 
{
	public float angle;

	void OnMouseDrag () 
	{
		float x = Input.GetAxis ("Mouse X");
		transform.RotateAround (transform.position, new Vector3 (0f, 1f, 0f) * Time.deltaTime *1* x, angle);
	}
}