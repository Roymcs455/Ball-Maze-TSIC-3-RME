using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    
    void OnTriggerExit(Collider collision)
    {
        if(collision.tag == "Ball")
        {
            gameManager.LoseLife();
        }
    }
}
