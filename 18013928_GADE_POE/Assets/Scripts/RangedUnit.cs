using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedUnit : MonoBehaviour
{
    
    public GameObject RangeUnit;
    public Sprite BlueArcherSprite;
    public Sprite RedArcherSprite;
    private SpriteRenderer spriteRenderer;
    FactoryBuilding factoryBuilding;
    //STATS
    float speed = 0.5f;
    public string faction;
    float health = 60f;
    float attack = 7f;
    float attackrange = 1.5f;
    bool isAttacking = false;

    public float yMovement;
    public float xMovement;
    int teamSelect;
    float nextdirection;
    public float nextDirectionChangeRate;
    float randDirection;
    private Rigidbody2D rb;
    private Vector2 movement = new Vector2();
    private string factionType;
    private string factionBuilding;
    
   public void CreateunitProperties(string faction)
    {
        this.faction = faction;
        
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = BlueArcherSprite;
        }
        rb = this.GetComponent<Rigidbody2D>();
        if (faction == "Blue")
        {
            spriteRenderer.sprite = BlueArcherSprite;
        }
        else
        {
            spriteRenderer.sprite = RedArcherSprite;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextdirection)
        {
            nextdirection = Time.time + nextDirectionChangeRate;


            nextDirectionChangeRate = Random.Range(1, 5);
            randDirection = Random.Range(0, 9);
            if (randDirection == 1)
            {
                xMovement = -1;
                yMovement = 0;
            }
            else if (randDirection == 2)
            {
                xMovement = 1;
                yMovement = 0;
            }
            else if (randDirection == 3)
            {
                xMovement = 0;
                yMovement = -1;
            }
            else if (randDirection == 4)
            {
                xMovement = 0;
                yMovement = 1;
            }
            else if (randDirection == 5)
            {
                xMovement = 1;
                yMovement = 1;
            }
            else if (randDirection == 6)
            {
                xMovement = -1;
                yMovement = 1;
            }
            else if (randDirection == 7)
            {
                xMovement = -1;
                yMovement = -1;
            }
            else if (randDirection == 8)
            {
                xMovement = 1;
                yMovement = -1;
            }

        }
        if (transform.position.x > 8.6)
        {
            //Destroy(BlueSword);
            xMovement = -1;
        }
        if (transform.position.x < -11.7)
        {
            // Destroy(BlueSword);
            xMovement = 1;
        }
        if (transform.position.y > 8)
        {
            yMovement = -1;
        }
        if (transform.position.y < -12.4)
        {
            yMovement = 1;
        }
        transform.position += new Vector3(xMovement, yMovement) * Time.deltaTime;
    }
}
