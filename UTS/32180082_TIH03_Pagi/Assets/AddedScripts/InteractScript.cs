using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public GameObject[] targets;
    public bool doRotateL 
    { 
        get; set; 
    }
    public bool doRotateR 
    { 
        get; set; 
    }

    public void ZoomIn()
    {
        foreach (GameObject target in targets)
        {
            target.transform.localScale = target.transform.localScale * 1.2f;
        }
    }

    public void ZoomOut()
    {
        foreach (GameObject target in targets)
        {
            target.transform.localScale = target.transform.localScale / 1.2f;
        }
    }

    public void RotateLeft()
    {
        foreach (GameObject target in targets)
        {
            target.transform.Rotate(new Vector3(0, 1.5f, 0));
        }
    }

    public void RotateRight()
    {
        foreach (GameObject target in targets)
        {
            target.transform.Rotate(new Vector3(0, -1.5f, 0));
        }
    }

    private void Update()
    {
        if (doRotateL)
        {
            RotateLeft();
        }

        if (doRotateR)
        {
            RotateRight();
        }
    }
}
