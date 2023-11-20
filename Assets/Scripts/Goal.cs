using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameManager gameManager;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Ball")
        {
            gameManager.AdvanceLevel();
        }
    }
}
