using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public bool isSelected = false;

	void Start ()
    {
		
	}

	void Update ()
    {
     
	}

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isSelected = true;
            Debug.Log("Cultist is selected");
        }
    }

}
