using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject wizard;
    float speed = 0.3f;
    public string faction = "Neutral";
    float health = 100f;
    float attack = 7f;
    float attackrange = 1.3f;
    bool isAttacking = false;
    public float xMovement;
    public float yMovement;
    float nextdirection;
    public float nextDirectionChangeRate;
    float randDirection;
    private Rigidbody2D rb;
    private Vector2 movement = new Vector2();
    public float Distance;
    public Transform wizardPos;
    public Transform buildingPos;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
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
                xMovement = -1 * speed;
                yMovement = 0 * speed;
            }
            else if (randDirection == 2)
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
        if (transform.position.y > 8) 
        {
            yMovement = -1 * speed;
        }
        if (transform.position.y < -12.4)
        {
            yMovement = 1 * speed;
        }
        transform.position += new Vector3(xMovement, yMovement) * Time.deltaTime;
    }
}
