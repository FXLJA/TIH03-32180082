using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().sleepThreshold = 0.0f;
    }
}
