using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Floor") {
            Debug.Log("Hit the floor");
        } else if(other.gameObject.name == "Wall1") {
            Debug.Log("Hit wall1");
        } else if(other.gameObject.name == "Wall2") {
            Debug.Log("Hit wall2");
        }
    }
}
