using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public GameObject Car;
  

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = Car.transform.position + new Vector3(0, 0, -10); 
    }
}
