using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }

    public void GameQuit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
