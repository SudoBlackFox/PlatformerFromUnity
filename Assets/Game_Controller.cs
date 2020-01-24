using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
	public static int hp = 5;
	public static int tile = 0;

	public static void damage()
	{
		hp --;
		Debug.Log(hp);
	}
	public static void press()
	{
		tile ++;
	}
	public static void heal()
	{
		if (hp < 5 && hp > 0)
		{
			hp ++;
			Debug.Log("Heal");
		}
	}
    void Update()
    {
        if (hp <=0)
        {
        	Invoke("ReloadLevel", 1/4);
        }
    }
    public void ReloadLevel ()
	{ 
		hp = 5;
		Application.LoadLevel (Application.loadedLevel);
	}
}
