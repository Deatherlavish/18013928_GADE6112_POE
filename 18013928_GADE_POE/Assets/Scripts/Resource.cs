using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    float health = 200;
    float resourceIncrease = 2;
    string faction;
    public GameObject resourcebuilding;
    public Sprite blueResourceSprite;
    public Sprite redResourceSprite;
    private SpriteRenderer spriteRenderer;
    public float factionType;
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
            spriteRenderer.sprite = blueResourceSprite;
        }
        if (faction == "Blue")
        {
            spriteRenderer.sprite = blueResourceSprite;
        }
        else
        {
            spriteRenderer.sprite = redResourceSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
