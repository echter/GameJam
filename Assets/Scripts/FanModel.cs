using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanModel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Rigidbody[] playerRigidbodyList; 
    
    void Start()
    {
     playerRigidbodyList = player.GetComponentsInChildren<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {

     Debug.Log(player.transform.position);

     foreach(Rigidbody rigidbody in playerRigidbodyList) {
         rigidbody.AddForce(0,2000,0);
     }

    }
}
