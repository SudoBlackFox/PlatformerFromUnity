using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour {

public void PlayPressed1()
    {
        SceneManager.LoadScene(1);
    }
public void PlayPressed2()
    {
        SceneManager.LoadScene("Level02");
    }
public void PressedMovie()
    {
        SceneManager.LoadScene("Move");
    }
public void MenuPressed()
    {
        SceneManager.LoadScene("menu");
    }
public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
