using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddown : MonoBehaviour {

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		StartCoroutine(Down(0.08f));
	}
	
	private IEnumerator Down(float value)
	{
		yield return new WaitForSeconds(value);
		Destroy(gameObject);
	}
}
