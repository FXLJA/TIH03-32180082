using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransformation : MonoBehaviour
{
    private Vector3 defaultPosition;
    private Vector3 defaultScale;
    private Quaternion defaultRotation;
    void Start()
    {
        defaultPosition = gameObject.transform.localPosition;
        defaultRotation = gameObject.transform.localRotation;
        defaultScale = gameObject.transform.localScale;
    }

    public void Reset()
    {
        gameObject.transform.localPosition = defaultPosition;
        gameObject.transform.localRotation = defaultRotation;
        gameObject.transform.localScale = defaultScale;
    }
}