using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrySpawn : MonoBehaviour
{
    // the game objects involved
    public GameObject MicroButton;
    public GameObject Curry;
    public AudioSource Beep;

    // Start is called before the first frame update
    void Start()
    {
        // disable beep at start
        Beep.Stop();
    }

    // if collision occurs
    void OnTriggerEnter(Collider collision)
    {
        // when the button is pressed, make a beep
        Beep.Play();
    }
}
