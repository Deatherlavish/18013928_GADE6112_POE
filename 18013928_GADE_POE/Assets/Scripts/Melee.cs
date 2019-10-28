using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject BlueSword;
    public Sprite blueMeleeSprite;
    public Sprite redMeleeSprite;
    private SpriteRenderer spriteRenderer;
    FactoryBuilding factoryBuilding;
    float speed = 1f;
   public string faction = "Blue";
   public float yMovement;
    //STATS
    float health = 100f;
    float attack = 4f;
    float attackrange = 0.04f;
    bool isAttacking = false;
        //ENDSTATS

   public float xMovement;
    int teamSelect;
    float nextdirection;
   public float nextDirectionChangeRate;
    float randDirection;
    private Rigidbody2D rb;
    private Vector2 movement = new Vector2();
    public float Distance;
    public Transform meleePos;
    public Transform buildingPos;
    public float distance;
    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = blueMeleeSprite;
        }
        rb = this.GetComponent<Rigidbody2D>();
        if(Vector2.Distance(meleePos.position , factoryBuilding.buildingspawn.position) < 1)
            {
            
        }
       if(faction == "Blue")
        {
            spriteRenderer.sprite = blueMeleeSprite;
        }
        else
        {
            spriteRenderer.sprite = redMeleeSprite;
        }
    }
    public void FactionRecieved(string faction)
    {
        this.faction = faction;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextdirection)
        {
            nextdirection = Time.time + nextDirectionChangeRate;

           
            nextDirectionChangeRate = Random.Range(1, 5);
            randDirection = Random.Range(0, 9);
            if(randDirection == 1)
            {
                xMovement = -1 * speed;
                yMovement = 0 * speed;
            }
            else if(randDirection == 2)
            {
                xMovement = 1 * speed;
                yMovement = 0 * speed;
            }
            else if (randDirection == 3)
            {
                xMovement = 0 * speed;
                yMovement = -1 * speed;
            }
            else if (randDirection == 4)
            {
                xMovement = 0 * speed;
                yMovement = 1 * speed;
            }
            else if (randDirection == 5)
            {
                xMovement = 1 * speed;
                yMovement = 1 * speed;
            }
            else if (randDirection == 6)
            {
                xMovement = -1 * speed;
                yMovement = 1 * speed;
            }
            else if (randDirection == 7)
            {
                xMovement = -1 * speed;
                yMovement = -1 * speed;
            }
            else if (randDirection == 8)
            {
                xMovement = 1 * speed;
                yMovement = -1 * speed;
            }
            
        }
        if (transform.position.x > 8.6)
        {
            //Destroy(BlueSword);
            xMovement = -1 * speed;
        }
        if (transform.position.x < -11.7)
        {
            // Destroy(BlueSword);
            xMovement = 1 * speed;
        }
        if(transform.position.y > 8)
        {
            yMovement = -1 * speed;
        }
        if (transform.position.y < -12.4)
        {
            yMovement = 1 * speed;
        }
        transform.position += new Vector3(xMovement, yMovement) *Time.deltaTime;
    }
}
