using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    [SerializeField] GameObject Aurora;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new(transform.position.x,transform.position.y,0);
        Instantiate(Aurora, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 