using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPick : MonoBehaviour {

	public float speed = 10f;
	public float direction = -1f;
	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		StartCoroutine(Dest(12.0f));
	}

	void FixedUpdate () 
	{
		rb.velocity = new Vector2 ( speed * direction, rb.velocity.y);
		transform.localScale = new Vector3 (direction, 1, 1);
	}	
	private IEnumerator Dest(float value)
	{
		yield return new WaitForSeconds(value);
		Destroy(gameObject);
	}
}
