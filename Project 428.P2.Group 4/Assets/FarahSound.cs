using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarahSound : MonoBehaviour
{
    // the game objects involved
    public GameObject Farah;
    public AudioSource Vine;

    // Start is called before the first frame update
    void Start()
    {
        // disable sound at start
        Vine.Stop();
    }

    // if collision occurs
    void OnTriggerEnter(Collider collision)
    {
        // when head is touched, play sound
        Vine.Play();
    }
}
