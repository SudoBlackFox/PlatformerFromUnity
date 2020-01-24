using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dam_fire : MonoBehaviour
{
    //private PlayerController pc;

	void Start ()
	{
		StartCoroutine(Dest(3.5f));
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        Game_Controller.damage();
        StartCoroutine(Dest(3.5f));
    }
    private IEnumerator Dest(float value)
	{
		yield return new WaitForSeconds(value);
		Destroy(gameObject);
	}
}
