using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFly : MonoBehaviour {

	// Use this for initialization
	public int many_tile;
	public GameObject[] array = new GameObject[3];
	public GameObject dog;
	public GameObject BG;
	public GameObject arch;
	public float dist;

	void Start ()
    {
        //InvokeRepeating("Create", 0, 4);
        for (float x = 0; x < many_tile * dist; x +=dist) 
        	{
            	Instantiate(array[Random.Range(0, 7)], new Vector3(-16f + x, -3, -1), Quaternion.identity);
        	}
        for (float x = 0; x < 30 * 11.41f; x += 11.41f) 
        	{
            	Instantiate(BG, new Vector3(-20f + x, 3.37f, 1), Quaternion.identity);
            	Instantiate(BG, new Vector3(-20f + x, -3.73f, 1), Quaternion.identity);
        	}
        Instantiate(dog, new Vector3(291, -1.71f, -2), Quaternion.identity);
        Instantiate(arch, new Vector3(292.63f, -0.45f, -1), Quaternion.identity);
    }
	
	//void Create ()
	//{
	//}

}