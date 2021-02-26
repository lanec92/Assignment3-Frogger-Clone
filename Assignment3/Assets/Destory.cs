using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    public GameObject blah;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Destroy(blah);
        }

    }
}
