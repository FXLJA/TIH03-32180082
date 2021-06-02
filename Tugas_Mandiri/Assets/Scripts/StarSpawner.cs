using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star_prefab;
    Transform[] children;

    void Awake()
    {
        children = GetComponentsInChildren<Transform>();
    }
    
    public GameObject SpawnStar()
    {
        int index = Random.Range(0, children.Length);
        return Instantiate(star_prefab, children[index]);
    }
}
