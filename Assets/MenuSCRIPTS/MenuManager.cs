using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator anim;
    public GameObject clickBegin;

    public void onClickBegin()
    {
        anim.enabled = true;
        Destroy(clickBegin);
    }

    public void onNewGame()
    {
        Application.LoadLevel("Scene_01");
    }

    public void onQuit()
    {
        if (UnityEditor.EditorApplication.isPlaying == true)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }

    }
}
