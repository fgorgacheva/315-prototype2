using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject magicCube;
    public GameObject wall;
    public GameObject particles;

    public AudioSource soundEffect;

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnMouseDown(){
        Destroy (magicCube);
        Destroy (wall);

        particles.SetActive(true);
        // soundEffect.SetActive(true);
        soundEffect.PlayOneShot(soundEffect.clip, 1);
    }
}
