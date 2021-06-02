using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StarScript : MonoBehaviour
{
    public UnityEvent OnInteract;
    public GameObject sound_prefab;

    void OnTriggerEnter(Collider collider)
    {
        OnInteract.Invoke();
        Destroy(Instantiate(sound_prefab), 2.0f);
        Destroy(gameObject);
    }
}
