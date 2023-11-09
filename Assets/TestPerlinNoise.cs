using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPerlinNoise : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        float x = Mathf.PerlinNoise(Time.time*10, 10);
        float y = Mathf.PerlinNoise(Time.time*10, 5);
        transform.position = new Vector3(x, y, 0);
    }
}
