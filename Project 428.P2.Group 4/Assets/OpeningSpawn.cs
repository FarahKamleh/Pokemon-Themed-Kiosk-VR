using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningSpawn : MonoBehaviour
{
    // the game objects involved
    public GameObject TVButton;
    public GameObject OpeningTheme;
    public AudioSource CenterMusic; 

    // Start is called before the first frame update
    void Start()
    {
        // make sure the object is not there at the start
        OpeningTheme.SetActive(false);
    }

    // if collision occurs
    void OnTriggerEnter(Collider collision)
    {
        // if inactive, make active
        if (OpeningTheme.activeSelf == false) {

            // turn on TV
            OpeningTheme.SetActive(true);

            // turn off music
            CenterMusic.Stop();
        }
        // if active, make inactive
        else {

            // turn off tv
            OpeningTheme.SetActive(false);

            // turn on music
            CenterMusic.Play();
        }

    }
}
