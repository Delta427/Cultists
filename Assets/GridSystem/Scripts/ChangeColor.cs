using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public Material[] material;
    Renderer rend;

    // Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        if (gameObject.CompareTag("wall"))
        {
            rend.sharedMaterial = material[1];
        }
        else if (gameObject.CompareTag("Trap"))
        {
            rend.sharedMaterial = material[2];
        }   



    }
	
	
}
