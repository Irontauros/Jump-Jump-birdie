using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addtrees : MonoBehaviour
{
    public GameObject trees;
    private float timeBtwSpawn;
    public float StartTimeBtwSpawn;


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(trees, transform.position, transform.rotation);
            timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
  
}
