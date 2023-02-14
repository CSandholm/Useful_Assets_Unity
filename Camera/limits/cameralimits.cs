using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralimits : MonoBehaviour
{
    [SerializeField]
    private Transform follow;
    
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(follow.position.x,0.93f,6.85f),
                                        Mathf.Clamp(follow.position.y,0.52f, 5.27f),
                                        transform.position.z);
    }
}
