using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    float _speed;
    // Start is called before the first frame update
    void Start()
    {
        _speed = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -12) {
            _speed = 0.005f;
        }
        if(transform.position.x > -7) {
            _speed = -0.005f;
        }
        transform.position = new Vector3(transform.position.x + _speed, transform.position.y, transform.position.z);
    }
}
