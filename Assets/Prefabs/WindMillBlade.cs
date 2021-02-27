using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMillBlade : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 100; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,speed*Time.deltaTime,Space.Self); 
    }
}
