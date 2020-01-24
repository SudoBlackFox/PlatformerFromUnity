using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingPad : MonoBehaviour {

	public float speed = 7f;
	public float direction = -1f;
	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "wall" || col.gameObject.tag == "pad") 
		{
			direction *= -1f;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.velocity = new Vector2 ( speed * direction, rb.velocity.y);
		transform.localScale = new Vector3 (direction, 1, 1);
	}
}
