using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingCube : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) {
        other.gameObject.GetComponent<Rigidbody>().AddForce(1000,0,0);
    }
}
