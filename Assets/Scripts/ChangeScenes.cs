using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void GoToSceneOne()
    {
        SceneManager.LoadScene("SceneOne");
    }
    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("SceneTwo");
    }

}
