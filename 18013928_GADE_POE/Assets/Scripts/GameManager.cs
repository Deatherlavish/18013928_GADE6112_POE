using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    float randomiser;
    public GameObject melee;
    public GameObject wizard;
    public GameObject archer;
    public GameObject factory;
    public GameObject resource;
    float WizardAmmount;
    float FactoryAmmount;
    float archerAmmount;
    float meleeAmmount;
    float resourceAmmount;
    float randX;
    float randY;
    Vector2 spawnlocations;

	// Use this for initialization
	void Start () {
        randomiser = Random.Range(5,10);
        WizardAmmount = Random.Range(2,randomiser);
        FactoryAmmount = Random.Range(3, randomiser);
        archerAmmount = Random.Range(4, randomiser);
        meleeAmmount = Random.Range(4, randomiser);
        resourceAmmount = Random.Range(3, randomiser);
        for(int i=0;i<WizardAmmount;i++)
        {
            randX = Random.Range(-11.7f , 8.5f);
            randY = Random.Range(-12.0f , 7.9f);

            spawnlocations = new Vector2(randX, randY);
            Instantiate(wizard, spawnlocations, Quaternion.identity);  //Wizard
        }
        for (int i = 0; i < FactoryAmmount; i++)
        {
            randX = Random.Range(-11.7f, 8.5f);
            randY = Random.Range(-12.0f, 7.9f);

            spawnlocations = new Vector2(randX, randY);
            Instantiate(factory, spawnlocations, Quaternion.identity); //factory
        }
        for (int i = 0; i < archerAmmount; i++)
        {
            randX = Random.Range(-11.7f, 8.5f);
            randY = Random.Range(-12.0f, 7.9f);

            spawnlocations = new Vector2(randX, randY);
            Instantiate(archer, spawnlocations, Quaternion.identity);
        }
        for (int i = 0; i < meleeAmmount; i++)
        {
            randX = Random.Range(-11.7f, 8.5f);
            randY = Random.Range(-12.0f, 7.9f);

            spawnlocations = new Vector2(randX, randY);
            Instantiate(melee, spawnlocations, Quaternion.identity);
        }
        for (int i = 0; i < resourceAmmount; i++)
        {
            randX = Random.Range(-11.7f, 8.5f);
            randY = Random.Range(-12.0f, 7.9f);

            spawnlocations = new Vector2(randX, randY);
            Instantiate(resource, spawnlocations, Quaternion.identity);//Redo for resource
        }

    }
	public int Round
    {
        get { return 1;}
    }
	// Update is called once per frame
	void Update () {
       // UpdateUnits();
       // UpdateBuildings();
       // round++;

	}
    //void UpdateUnits()
   // {
      
   // }
    //private void StayInBounds(Unit unit)
   // {
     //   Vector3 unitPosition = unit.transform.position;
     //   if(unitPosition.x < 0)
     //   {
     //       unitPosition.x = 0;
     //   }
     //   else if(unitPosition.x >= width)
     //   {
     //       unitPosition.x = width - 1;
      //  }
     //   if(unitPosition.y <0)
     //   {
     //       unitPosition.y = 0;
     ///   }
      //  else if (unitPosition.y >= height)
     //   {
     //       unitPosition.y = height - 1;
     //   }
     //   unit.transform.position = 2;  //UPDATE
    //}
}
