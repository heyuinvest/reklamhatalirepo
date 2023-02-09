using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public bool isPlayerBullet;
    public bool isRight, isLeft, Center;


    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {   
        
        Vector2 position = transform.position;
        if(isRight == true)
        {
            position = new Vector2 (position.x + speed * Time.deltaTime, position.y + speed * Time.deltaTime);

        }
        else
        {
            position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        }
        if(isLeft == true)
        {
            position = new Vector2 (position.x + -speed * Time.deltaTime, position.y + speed * Time.deltaTime);

        }
        else
        {
            position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        }
        position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        transform.position = position;

        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1,1));

        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Enemy"))
            {
                if(isPlayerBullet == true)
                {

                    Destroy(gameObject);
                }
        
            
                

            }
    
    }
    
    
    
}

