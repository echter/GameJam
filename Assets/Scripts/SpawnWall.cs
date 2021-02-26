using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{

    public GameObject player;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Instantiate(wall, player.transform.position + new Vector3(0, 0, 200), player.transform.rotation);
            timer = 0;
        }
    }
}
