using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownFly : MonoBehaviour {

	public float speed = 10f;
	public float direction = -1f;
	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		StartCoroutine(Dest(1.0f));
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
	void OnTriggerEnter2D(Collider2D col)
    {
    	if (col.gameObject.tag == "fly" || col.gameObject.tag == "frost" || col.gameObject.tag == "shell" || col.gameObject.tag == "heal" || col.gameObject.tag == "Player" || col.gameObject.tag == "Player_shell")
			{
				Destroy(gameObject);
			}
        Game_Controller.damage();
    }
}
