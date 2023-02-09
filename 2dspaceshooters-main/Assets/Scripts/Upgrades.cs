using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    // Start is called before the first frame update
    public int bulletCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other) 
    {

        
        
        if (other.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            
        }
}

void OnTriggerEnter2D(Collider2D other) 
    {

        
        
        if (other.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            
        }
}
}
