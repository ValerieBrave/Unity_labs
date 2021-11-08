using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject greenPrefab;
    public GameObject redPrefab;

    float maxZ=30;
    float minZ=5;
    float maxX=30;
    float minX=5;

    



    void Start()
    {
        for(int i =0; i< 10; i++) {
        float newX1 = Random.Range(minX, maxX);
        float newZ1 = Random.Range(minZ, maxZ);
        float newX2 = Random.Range(minX, maxX);
        float newZ2 = Random.Range(minZ, maxZ);

        Instantiate(greenPrefab, new Vector3(newX1, 5, newZ1), Quaternion.identity);
        Instantiate(redPrefab, new Vector3(newX2, 5, newZ2), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
