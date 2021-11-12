using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float zoomSpeed;
    public float sensitivity;
    public Camera camera;
    public GameObject cube;

    // void Start()
    // {

    // }

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            float zoomDistance = zoomSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
            camera.transform.Translate(ray.direction * zoomDistance, Space.World);

            Vector3 vp = camera.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane));
            vp.x -= 0.5f;
            vp.y -= 0.5f;
            vp.x *= sensitivity;
            vp.y *= sensitivity;
            vp.x += 0.5f;
            vp.y += 0.5f;
            Vector3 sp = camera.ViewportToScreenPoint(vp);

            Vector3 v = camera.ScreenToWorldPoint(sp);
            transform.LookAt(v, Vector3.up);
        }
        
    }
    // void Update(){
    //     transform.LookAt(cube.transform);
    //     transform.Translate(Vector3.right * Time.deltaTime);
    // }
}
