using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRaycastDetection : MonoBehaviour
{
    float RaycastDistance { get; set; }= 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position,this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(this.transform.position,this.transform.forward, out hit, RaycastDistance))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}
