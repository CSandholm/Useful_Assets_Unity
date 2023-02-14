using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class weapon : MonoBehaviour
{
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)) 
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.DetachChildren();
            FindObjectOfType<uiink>().use();
            FindObjectOfType<AudioManager>().Play("ink");
        }   
    }    
}
