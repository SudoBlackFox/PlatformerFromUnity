using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(PlayerController))]
public class UserControll : MonoBehaviour {

	private PlayerController pc;
	public GameObject menu;
	// Use this for initialization
	void Start () {
		pc = GetComponent<PlayerController> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			pc.Jump ();
		}
		pc.Move (Input.GetAxis("Horizontal"));
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			menu.SetActive(true);
			Debug.Log("Open!");
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			Time.timeScale = 0f;
		}
		else 
		{
			Time.timeScale = 1f;
		}
	}
}
