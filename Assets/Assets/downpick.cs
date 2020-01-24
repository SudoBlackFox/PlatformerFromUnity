using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downpick : MonoBehaviour {

	// Use this for initialization
	public GameObject enemy;

	public void OnCollisionEnter2D(Collision2D shit)
	{
		if (shit.gameObject.tag == "Player") 
		{
			Game_Controller.press();
			gameObject.tag = "pad";
			for (int i = 0; i < 3; i++)
    		{
        		StartCoroutine(Create());
        	}
		}
	}
	
	IEnumerator Create()
	{
		yield return new WaitForSeconds(1f);
		//интервал 7
		Instantiate(enemy, new Vector3(transform.position.x + (Random.Range(-3, 5)), transform.position.y + 7, 0), Quaternion.identity);

	}
}