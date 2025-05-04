using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public AudioSource source;
    public AudioClip Shine;

    public void GoToSceneOne()
    {
        source.PlayOneShot(Shine);
        SceneManager.LoadScene("SceneOne");
    }
    public void GoToSceneTwo()
    {
        source.PlayOneShot(Shine);
        SceneManager.LoadScene("SceneTwo");
    }

}
