using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube_Behaviour : MonoBehaviour
{
    public GameObject leadingCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, leadingCube.transform.position, Time.deltaTime);
    }
}
