using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOre : MonoBehaviour
{
    private int clicks;
    public AudioSource hitSound;
    public AudioSource breakSound;


    // Update is called once per frame
    void Update()
    {
        if(hitSound == null){
            this.hitSound = GameObject.Find("hitSound").GetComponent<AudioSource>();
        }

        if(breakSound == null){
            this.breakSound = GameObject.Find("breakSound").GetComponent<AudioSource>();
        }
    }

    void OnMouseDown(){
        if(clicks == 8){
            Destroy(gameObject);
            breakSound.PlayOneShot(breakSound.clip, 1);
        } else {
            clicks++;
            hitSound.PlayOneShot(hitSound.clip, 1);
        }
    }
}
