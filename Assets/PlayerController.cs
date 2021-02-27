using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject playerReferenceObject;

    float startPoint;
    public float distanceTraveled = 0;

    public int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = playerReferenceObject.gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTraveled = playerReferenceObject.gameObject.transform.position.z - startPoint;

        level = (int)distanceTraveled / 100;
    }
}
