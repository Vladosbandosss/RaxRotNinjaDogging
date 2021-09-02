using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        audioSource.Play();
    }

  public void ExitGAme()
    {
        Application.Quit();
    }
    public void StartPlaying()
    {
        SceneManager.LoadScene("Game");
    }
}
