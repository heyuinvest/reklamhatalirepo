using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public bool isPlayerBullet;

    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

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

