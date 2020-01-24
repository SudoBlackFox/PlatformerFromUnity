using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings : MonoBehaviour {
	bool isFullScreen;

	public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
}
