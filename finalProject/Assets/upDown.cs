using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDown : MonoBehaviour
{
    public float speed = 1f;
     void Update()
    {
        transform.Rotate(0,0, 0 * speed * Time.deltaTime);
    }
}


