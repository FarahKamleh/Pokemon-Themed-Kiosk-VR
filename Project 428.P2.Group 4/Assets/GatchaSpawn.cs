using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatchaSpawn : MonoBehaviour
{
    public GameObject Button;
    public GameObject Pokeball;
    public Vector3 poke_pos;
    public Quaternion poke_rotation;
    void start() {
        poke_pos = Pokeball.transform.position;
        poke_rotation = Pokeball.transform.rotation;
        Destroy(Pokeball);
    }
    void ButtonTouched() {
        // Button touched
        GameObject pokeB = Instantiate(Pokeball, poke_pos, poke_rotation);
        pokeB.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
        print("pokeball spawned");
    }
}
