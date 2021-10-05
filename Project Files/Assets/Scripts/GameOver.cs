using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    AudioSource sound;
    [SerializeField] AudioClip deathSound;

    void Start() 
    {
        sound=GetComponent<AudioSource>();
        sound.PlayOneShot(deathSound);
    }
    void Update()
    {
        if (Input.GetKeyDown( KeyCode.F))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
