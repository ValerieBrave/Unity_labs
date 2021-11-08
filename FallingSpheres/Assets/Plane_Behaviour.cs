// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Plane_Behaviour : MonoBehaviour
// {
//     // Start is called before the first frame update
//     MeshRenderer render;
//     void Start()
//     {
//         render = gameObject.GetComponent<MeshRenderer>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//         float minX = render.bonus.min.x;
//         float minZ = render.bonus.min.z;
//         float maxX = render.bonus.max.x;
//         float maxZ = render.bonus.max.z;

//         float newX = Random.Range(minX, maxX);
//         float newZ = Random.Range(minZ, maxZ);
//         float newY = gameObject.transform.position.y + 5;

//         if(Input.GetKeyDown(KeyCode.Space)) {
//             GameObject cubb = GameObject.CreatePrimitive(PrimitiveType.Cube);
//             cubb.transform.position = new Vector3(newX, newY, newZ);
//             cubb.AddComponent<Rigidbody>();
//         }
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Behaviour : MonoBehaviour
{
private MeshRenderer render;
private float minX;
private float maxX;
private float minZ;
private float maxZ;


// Start is called before the first frame update
void Start()
{
render = gameObject.GetComponent<MeshRenderer>();
minX = render.bounds.min.x;
maxX = render.bounds.max.x;
minZ = render.bounds.min.z;
maxZ = render.bounds.max.z;

}

// Update is called once per frame
void Update()
{
float newX = Random.Range(minX, maxX);
float newZ = Random.Range(minZ, maxZ);
float newY = Random.Range(6, 20);

if (Input.GetMouseButtonDown(0))
{

GameObject cubb = GameObject.CreatePrimitive(PrimitiveType.Cube);

cubb.transform.position = new Vector3(newX, newY, newZ);
cubb.AddComponent<Rigidbody>();
cubb.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

}
}

}