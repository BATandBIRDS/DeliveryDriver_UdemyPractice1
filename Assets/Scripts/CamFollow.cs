using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] GameObject WhatToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = WhatToFollow.transform.position + new Vector3(0,0,-11);
        
    }
}
