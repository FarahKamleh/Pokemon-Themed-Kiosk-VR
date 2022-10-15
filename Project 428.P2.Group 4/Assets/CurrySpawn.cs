using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrySpawn : MonoBehaviour
{
    // the game objects involved
    public GameObject MicroButton;
    public GameObject Curry;
    public AudioSource Beep;

    // for position, rotation, and scale
    public Vector3 cPosition;
    public Quaternion cRotation;
    public Vector3 cScale;

    // Start is called before the first frame update
    void Start()
    {
        // disable beep at start
        Beep.Stop();

        // copy the initial position, rotation, and scale of the curry in the scene
        cPosition = Curry.transform.position;
        cRotation = Curry.transform.rotation;
        cScale = Curry.transform.localScale;

        // move initial curry out of the way
        Curry.transform.position = new Vector3(150, 150, 150);

    }

    // if collision occurs
    void OnTriggerEnter(Collider collision)
    {
        // when the button is pressed, make a beep
        Beep.Play();

        // create new curry in microwave
        GameObject SpawnedCurry = Instantiate(Curry, cPosition, cRotation);
    }
}
