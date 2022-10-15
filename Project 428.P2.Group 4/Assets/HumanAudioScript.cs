using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAudioScript : MonoBehaviour
{
    // the game objects involved
    public GameObject AVATAR;
    void playSound(){
        AVATAR.GetComponent<AudioSource>().Play();
        print("lalalala");
    }
}
