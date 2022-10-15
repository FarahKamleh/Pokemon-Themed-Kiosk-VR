using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatchaSpawn : MonoBehaviour
{
    public GameObject Button;
    public GameObject Pokeball;
    public Vector3 poke_pos;
    public Quaternion poke_rotation;
    public Vector3 scale;
    void Start() {
        poke_pos = Pokeball.transform.position;
        poke_rotation = Pokeball.transform.rotation;
        poke_pos += new Vector3(0, -0.1f, -0.02f);
        scale = Pokeball.transform.localScale;
        Pokeball.transform.position = new Vector3(100, 100, 100);
        
    }
    void ButtonTouched() {
        // Button touched
        GameObject pokeB = Instantiate(Pokeball, poke_pos, poke_rotation);
        pokeB.transform.localScale += new Vector3(0.3f,0.3f,0.3f);
        pokeB.GetComponent<Rigidbody>().velocity = new Vector3(-0.5f, 0, 0);
        // pokeB.transform.position += new Vector3(0, 0, 0.003f);
        print("pokeball spawned");
    }
}
