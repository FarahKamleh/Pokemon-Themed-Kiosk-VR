using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingStationScript : MonoBehaviour
{
    public GameObject HealingSpot;
    public GameObject Eve;
    public GameObject Evoled_Eve;
    public ParticleSystem Particle_1;
    void Start()
    {
        Particle_1.Stop();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision) {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (HealingSpot.name == contact.thisCollider.name && (Eve.name == contact.otherCollider.name || Evoled_Eve.name == contact.otherCollider.name)
                && !Particle_1.isPlaying) {
                print("Healing Station Triggered");
                swap();
                Eve.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
                Evoled_Eve.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
                Particle_1.Play();
            }
        }
    }
    void swap() {
        var temp_pos = Eve.transform.position;
        Eve.transform.position = Evoled_Eve.transform.position;
        Evoled_Eve.transform.position = temp_pos;
    }
}
