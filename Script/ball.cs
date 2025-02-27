using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour 
{
	int score;
	public GameObject Splash_Prefab;
	public float force;
	public Text score_txt;
	//public GameObject GameMenu;

	void OnCollisionEnter(Collision Col) {

		if (Col.gameObject.tag == "h_piece" ) {
			gameObject.GetComponent<AudioSource>().Play();
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, 1f, 0f) * Time.deltaTime * force);
			GameObject splash = Instantiate(Splash_Prefab);
			Vector3 pos = transform.position;
			pos.y = pos.y - 0.2f;

			splash.transform.SetParent (GameObject.Find ("helix").transform);
		}
		else if (Col.gameObject.tag == "gameover") 
		{
			SceneManager.LoadScene("LoseGame");
			//GameMenu.SetActive (true);
		}
		else if (Col.gameObject.tag == "wingame")
		{
			SceneManager.LoadScene("WinGame");
		}
	}
	void OnTriggerEnter(Collider c)
	{
		 if (c.gameObject.tag == "score_tag") 
		{
			score++;
			score_txt.text = score + "";
		}
	}
	void Update()
	{
		if (transform.position.y < Camera.main.transform.position.y) 
		{
			Vector3 pos = Camera.main.transform.position;
			pos.y = transform.position.y + 2.3f;
			Camera.main.transform.position = pos;
		}
	}
}