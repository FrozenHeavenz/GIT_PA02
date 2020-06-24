using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject IceBlock;
    public GameObject Tire;
    public GameObject Walrus;

    public float Rand;
    public int xRand;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObjects()
    {
        Rand = Random.Range(0, 4);
        xRand = Random.Range(-3, 3);
        Vector3 xOffset = new Vector3(xRand, 0.1f);

        if(Rand == 0)
        {
            Instantiate(Barrel, xOffset , Quaternion.identity);
        }
        if(Rand == 1)
        {
            Instantiate(IceBlock, xOffset, Quaternion.identity);
        }
        if (Rand == 2)
        {
            Instantiate(Tire, xOffset, Quaternion.identity);
        }
        if (Rand == 3)
        {
            Instantiate(Walrus, xOffset, Quaternion.identity);
        }
    }
}
