using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float runSpeed = 15f;
	public float jumpForce = 5f;
	public Transform cirTarg;
	public float radCir = 0.3f;
	private Rigidbody2D rb;
	public GameObject player; 

	public GameObject Menu;
	public GameObject Exit;
	public GameObject Victory;
	public GameObject Fale;
	public GameObject Fale_run;
	public GameObject Return;
	public int score;
	private GUIStyle fontSize;

	float bufTimer;
	float bufTime = 5;

	

	void Start() 
	{
		player = (GameObject)this.gameObject; 
		rb = GetComponent<Rigidbody2D> ();
		fontSize = new GUIStyle();
        fontSize.fontSize = 32;
	}
	void OnGUI()
     {
         GUI.Label(new Rect(20, 40, 200, 50), "Life: " + Game_Controller.hp + "/5", fontSize);
     }
	bool isGround() 
	{
		Collider2D[] gh = Physics2D.OverlapCircleAll (cirTarg.position, radCir);
		int j = 0;
		for (int i =0; i < gh.Length; i++) 
		{
			if(gh[i].gameObject!=gameObject) 
			{
				j++;
			}
		}
		return j > 0;
	}

	//void OnGUI()
	//{
	//	GameObject box = GUI.Box (new Rect (0, 0, 200, 50), "Life: " + Game_Controller.hp + "/5");

	//}

	public void OnCollisionEnter2D(Collision2D shit)
	{
			if (shit.gameObject.tag == "frost")
			{
     			runSpeed -= 8f;
				jumpForce -= 2.5f;
				Game_Controller.press();
				shit.gameObject.tag = "pad";
				StartCoroutine(Frost());
			}
			if (shit.gameObject.tag == "fly")
			{
				rb.gravityScale = 2.8f;
				shit.gameObject.tag = "pad";
				StartCoroutine(Fly());
			}
			if (shit.gameObject.tag == "heal")
			{
				Game_Controller.heal();
				shit.gameObject.tag = "pad";
			}
			if (shit.gameObject.tag == "shell")
			{
				gameObject.tag = "Player_shell";
				shit.gameObject.tag = "pad";
				StartCoroutine(Shell());
			}
			if (shit.gameObject.tag == "Finish")
			{
				if (Game_Controller.tile >= 12)
				{
					Menu.SetActive(true);
					Fale.SetActive(true);
					Victory.SetActive(false);
					Fale_run.SetActive(true);
					Return.SetActive(false);
					Exit.SetActive(true);
				}
				else if (Game_Controller.tile >= 20)
				{
					Menu.SetActive(false);
					Fale.SetActive(false);
					Victory.SetActive(false);
					Fale_run.SetActive(true);
					Return.SetActive(false);
					Exit.SetActive(true);
				}
				else
				{
					Menu.SetActive(true);
					Fale.SetActive(false);
					Fale_run.SetActive(false);
					Victory.SetActive(true);
					Return.SetActive(false);
				}
				
			}
	}
	IEnumerator Shell()
	{
		yield return new WaitForSeconds(2.5f);
		gameObject.tag = "Player";
	}
	IEnumerator Frost()
	{
		yield return new WaitForSeconds(3f);
		runSpeed += 8f;
		jumpForce += 2.5f;
	}
	IEnumerator Fly()
	{
		yield return new WaitForSeconds(4f);
		rb.gravityScale = 5;
	}

	public void ReloadLevel ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Jump() 
	{
		if (isGround()) 
		{
			rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
		}
	}
	public void Move(float ax) 
	{
		Vector3 direction = transform.right * ax;
		transform.position = Vector3.Lerp(transform.position, transform.position + direction, runSpeed*Time.deltaTime);
		if ((ax > 0 && transform.localScale.x < 0) || (ax < 0 && transform.localScale.x > 0))
		{
			transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
	}

}
