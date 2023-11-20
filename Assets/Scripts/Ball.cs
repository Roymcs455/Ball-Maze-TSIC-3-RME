using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnTriggerExit(Collider col)
    {
        if(col.name == "Bounds")
        {
            Destroy(gameObject);
            
        }
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Goal")
        {
            Destroy(gameObject);
        }
    }
}
