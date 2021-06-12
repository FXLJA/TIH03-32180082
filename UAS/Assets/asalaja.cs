using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asalaja : MonoBehaviour
{
    // Start is called before the first frame update
    public Material red;
    public Material white;
    MeshRenderer current;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            hit.transform.GetComponent<MeshRenderer>().material = red;
            current = hit.transform.GetComponent<MeshRenderer>();
        }
            else if(current != null)
            {
                current.material = white;
            }
    }
}
