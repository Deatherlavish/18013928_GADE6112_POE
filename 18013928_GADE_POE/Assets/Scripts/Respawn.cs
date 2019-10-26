using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject swordsmen;
    public GameObject archers;
    public float randX;
    public float randY;
    float respawnSpeed;
    Vector2 spawnlocations;
    public float spawnRate = 4;
    float nextspawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextspawn)
        {
            nextspawn = Time.time + spawnRate;
            randX = Random.Range(-4, 4);  //move to spawneer
            randY = Random.Range(-4, 4);  //move to spawner
            spawnlocations = new Vector2(randX,randY);
            Instantiate(swordsmen, spawnlocations,Quaternion.identity);
        }
    }
}
