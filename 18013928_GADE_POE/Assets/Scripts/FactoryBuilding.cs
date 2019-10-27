using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBuilding : MonoBehaviour
{
   

    RangedUnit rangedUnit;
    Melee melee;
    public GameObject Tent;
    public Sprite blueFactorySprite;
    public Sprite redFactorySprite;
    private SpriteRenderer spriteRenderer;
    public GameObject swordsmen;
    public GameObject archers;
    public float randX;
    public float randY;
    string unitType;
    public float spawnSpeed = 5;
   public Vector2 spawnlocations;
    public float spawnRate = 4;
    public float spawntime;
    float nextspawn = 0;
    public float randomiser;
    public Transform buildingspawn;
    Vector2 buildingpos;
    
    string faction;

   
   
    enum UnitType
    {
        Melee, Ranged
    }
    public int tester;
    // Start is called before the first frame update
   
    void Start()
    {
        
        faction = "Blue";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawntime)
        {
            
            faction = "Blue"; //test
            tester += 1;
            spawntime = Time.time + spawnSpeed;
            randomiser = Random.Range(1,3);
            if(randomiser == 1)
            {
                if(faction == "Blue")
                {
                    melee.CreateunitProperties(faction);
                    Instantiate(swordsmen, spawnlocations, Quaternion.identity);

                }
                else if (faction == "Red")
                {
                   melee.CreateunitProperties("Red");
                    Instantiate(swordsmen, spawnlocations, Quaternion.identity);
                    
                }
            }
            else 
            {
                if (faction == "Blue")
                { 
                    rangedUnit.CreateunitProperties("Blue");
                    Instantiate(archers, spawnlocations, Quaternion.identity);
                }
               else if (faction == "Red")
                {
                    rangedUnit.CreateunitProperties("Red");
                    Instantiate(archers, spawnlocations, Quaternion.identity);
                }
            }

        }
    }
}