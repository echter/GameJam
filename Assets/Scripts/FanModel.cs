using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class FanModel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Rigidbody[] playerRigidbodyList; 

    private int triggerDistance = 10;
    
    void Start()
    {
     playerRigidbodyList = player.GetComponentsInChildren<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
     float dist = Math.Abs(player.transform.position.z - gameObject.transform.position.z);
     Debug.Log(dist);
     if (dist <= triggerDistance) 
     {
        foreach(Rigidbody rigidbody in playerRigidbodyList) 
        {
            rigidbody.AddForce(0,0,-10);
        }
     }

    }
}
