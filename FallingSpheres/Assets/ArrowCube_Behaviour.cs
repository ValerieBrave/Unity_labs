using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCube_Behaviour : MonoBehaviour
{
    public float speed = 5;
    public GameObject followingSphere;
    private Rigidbody rb;
    Renderer rend;
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        
        if (Input.GetKey("up"))
        {
            rend.material.color =  colorEnd;
        }

        if (Input.GetKey("down"))
        {
            rend.material.color =  colorStart;
        }


        followingSphere.transform.position = Vector3.MoveTowards(followingSphere.transform.position, transform.position, Time.deltaTime);
    }
}
