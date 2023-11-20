using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject ball;

    public void SpawnBall()
    {
        Instantiate<GameObject>(ball,this.transform,worldPositionStays:false);
    }
    
}
