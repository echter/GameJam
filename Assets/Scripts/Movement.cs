using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject referenceObject;
    public Rigidbody[] bodyParts;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (referenceObject.transform.position.y < -10)
        {
            bodyParts = GetComponentsInChildren<Rigidbody>();

            foreach (Rigidbody joint in bodyParts)
            {
                joint.AddForce(0, 500, 0);
            }
        }

        if (referenceObject.transform.position.y > 30)
        {
            bodyParts = GetComponentsInChildren<Rigidbody>();

            foreach (Rigidbody joint in bodyParts)
            {
                joint.AddForce(0, -50, 0);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            bodyParts = GetComponentsInChildren<Rigidbody>();

            foreach (Rigidbody joint in bodyParts)
                joint.AddForce(-10, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            bodyParts = GetComponentsInChildren<Rigidbody>();

            foreach (Rigidbody joint in bodyParts)
                joint.AddForce(10, 0, 0);
        }
    }
}
