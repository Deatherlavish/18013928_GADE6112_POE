using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBuilding : MonoBehaviour
{
    public GameObject Tent;
    public Sprite blueFactorySprite;
    public Sprite redFactorySprite;
    private SpriteRenderer spriteRenderer;
    public GameObject swordsmen;
    public GameObject archers;
    public float randX;
    public float randY;
    float respawnSpeed;
    Vector2 spawnlocations;
    public float spawnRate = 4;
    float nextspawn = 0;
    
    string faction;
    enum UnitType
    {
        Melee, Ranged
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
