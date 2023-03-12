using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform parent;
    private bool pickedUp = false;
    // Update is called once per frame
    void Update()
    {
        var anim = gameObject.GetComponent<Animator>();
       if (Input.GetMouseButtonDown(0) && pickedUp)
       {
            anim.enabled = true;
            anim.Play("pick");
       }
    }

    void OnMouseDown(){
        Debug.Log("clicked");
        this.transform.SetParent(parent);
        this.pickedUp = true;
        
        this.transform.localPosition = new Vector3(0.4f,0,0);
        this.transform.localEulerAngles = new Vector3(0, 90, 45);
    }
}
