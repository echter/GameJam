using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class FanModel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Rigidbody[] playerRigidbodyList; 

    private int triggerDistanceZ = 20;
    private int triggerDistanceX = 4; 
    
    void Start()
    {
     playerRigidbodyList = player.GetComponentsInChildren<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
     float distZ = gameObject.transform.position.z - player.transform.position.z;
     float distX = gameObject.transform.position.x - player.transform.position.x; 
     bool isZActive = distZ > 0 && distZ <= triggerDistanceZ; 
     bool isXActive = Math.Abs(distX) <= triggerDistanceX;
     
     if (isXActive && isZActive) 
     {
        foreach(Rigidbody rigidbody in playerRigidbodyList) 
        {
            rigidbody.AddForce(0,0,-1000);
        }
     }

    }
}
