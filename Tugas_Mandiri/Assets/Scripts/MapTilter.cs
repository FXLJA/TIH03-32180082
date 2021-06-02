using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTilter : MonoBehaviour
{
    public bl_Joystick joystick;

    public void Update()
    {
        Vector3 cameraRelative = Camera.main.transform.TransformDirection(joystick.Vertical, 0, -joystick.Horizontal);
        
        float xRotation = Remap(cameraRelative.x, -5, 5, -15, 15);
        float zRotation = Remap(cameraRelative.z, -5, 5, -15, 15);
        
        Vector3 desired_rotation = new Vector3(xRotation, 0, zRotation);;
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(desired_rotation), 0.01f);
    }

    public float Remap (float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
}
