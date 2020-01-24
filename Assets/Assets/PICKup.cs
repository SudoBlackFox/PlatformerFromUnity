using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PICKup : MonoBehaviour {

	//public Get Trigger;

	public void OnTriggerEnter2D (Collider2D other) 
	{
		transform.Translate(new Vector2(0, 15f));
		//Destroy(gameObject);
	}
}