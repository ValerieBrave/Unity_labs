using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.AI;

public class MoveCube : MonoBehaviour, IPointerClickHandler
{
     Rigidbody rb;
    float force;
    public InputField field;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        if (!float.TryParse(field.text, out force))
        {
            force = 0.1f;
        }
        

        
        
        if(Physics.Raycast(ray, out hit)){
            //rb.AddForce(hit.point.x*force, hit.point.y*force, hit.point.z*force, ForceMode.Impulse);
            rb.AddForce(-(hit.point - rb.transform.position)*force, ForceMode.Impulse);
        }
    }
}
