using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillCollision : MonoBehaviour
{
    public GameObject player;
    Rigidbody[] playerRigidbodyList;

    private int triggerDistanceZ = 20;
    private int triggerDistanceX = 4;

    void Start()
    {
        playerRigidbodyList = player.GetComponentsInChildren<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            foreach (Rigidbody rigidbody in playerRigidbodyList)
            {
                rigidbody.AddForce(gameObject.transform.forward * -1000);
            }
        }
    }
}
