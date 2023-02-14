using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rreset : MonoBehaviour
{
    public GameObject player;
    public GameObject ink;
    private bool allow;


    void Start() 
    {
        allow = true;
    }
    void Update()
    {
        player = GameObject.Find("player");
    }
    private void FixedUpdate()
    { 
        if(ink.activeInHierarchy == true && allow == true)
        {
        Invoke("remain",5f);
        allow = false;
        }
    }
    void remain()
    {
        gameObject.SetActive(false);
        Invoke("reload",5f);
    }
    void reload()
    {
        transform.position = player.transform.position;
        transform.parent = player.transform;
        allow = true;
    }
}
