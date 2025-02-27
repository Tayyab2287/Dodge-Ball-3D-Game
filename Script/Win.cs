using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	void OnCollisionEnter(Collision Col)
	{
		if (Col.gameObject.tag == "wingame")
		{
			gameObject.GetComponent<AudioSource>().Play();
		}
	}
}
