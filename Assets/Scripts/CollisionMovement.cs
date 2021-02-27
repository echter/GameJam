using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMovement : MonoBehaviour
{

    public Rigidbody[] bodyParts;

    private void OnCollisionStay(Collision collision)
    {

        bodyParts = GetComponentsInChildren<Rigidbody>();

        if (collision.gameObject.name == "Ground")
        {
            foreach (Rigidbody joint in bodyParts)
            {
                joint.AddForce(Random.Range(-1000, 1000) * 5, Random.Range(100, 500), Random.Range(100, 1000) * 0.3f);
            }
        }
    }
}
