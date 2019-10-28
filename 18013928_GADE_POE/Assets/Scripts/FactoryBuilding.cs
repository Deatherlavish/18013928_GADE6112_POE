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
    public float factionType;
    public Transform buildingspawn;
    public Vector3 buildingpos;
   
    public Collider2D collider;
    string faction;
    object factionObj;
    float health = 200;
   
    enum UnitType
    {
        Melee, Ranged
    }
    public int tester;
    // Start is called before the first frame update
   
    void Start()
    {
        factionType = Random.Range(1, 3);
        if (factionType == 1)
        {
            faction = "Blue";


        }
        else
        {
            faction = "Red";
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = blueFactorySprite;
        }
        if (faction == "Blue")
        {
            spriteRenderer.sprite = blueFactorySprite;
        }
        else
        {
            spriteRenderer.sprite = redFactorySprite;
        }
        factionObj = faction;
        collider.enabled = false;
        
        
    }
    public void FactionReciever()
    {
        
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
                    //melee.CreateunitProperties(this.faction);
                    Instantiate(swordsmen,buildingspawn.position, Quaternion.identity);

                }
                else if (faction == "Red")
                {
                  // melee.CreateunitProperties(this.faction);
                    Instantiate(swordsmen, buildingspawn.position, Quaternion.identity);
                    
                }
            }
            else 
            {
                if (faction == "Blue")
                { 
                   // rangedUnit.CreateunitProperties(this.faction);
                    Instantiate(archers, buildingspawn.position, Quaternion.identity);
                }
               else if (faction == "Red")
                {
                    //rangedUnit.CreateunitProperties(this.faction);
                    Instantiate(archers, buildingspawn.position, Quaternion.identity);
                }
            }

        }
    }
}