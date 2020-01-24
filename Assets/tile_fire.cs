using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_fire : MonoBehaviour
{

	public GameObject fire;
	

	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
		{
			gameObject.tag = "pad";
			Game_Controller.press();
        	StartCoroutine(fire_01(0f));
        	StartCoroutine(fire_02(1.3f));
        	StartCoroutine(fire_03(2.6f));
		}
    }
    IEnumerator fire_01( float x)
	{
		yield return new WaitForSeconds(0.2f);
		Instantiate(fire, new Vector3(transform.position.x + x, -1.87f, -1), Quaternion.identity);
	}
	IEnumerator fire_02( float x)
	{
		yield return new WaitForSeconds(0.5f);
		Instantiate(fire, new Vector3(transform.position.x + x, -1.87f, -1), Quaternion.identity);
	}
	IEnumerator fire_03( float x)
	{
		yield return new WaitForSeconds(0.7f);
		Instantiate(fire, new Vector3(transform.position.x + x, -1.87f, -1), Quaternion.identity);
	}
    void Create ()
	{
		Instantiate(fire, new Vector3(transform.position.x, -1.87f, 0), Quaternion.identity);
	}
}
