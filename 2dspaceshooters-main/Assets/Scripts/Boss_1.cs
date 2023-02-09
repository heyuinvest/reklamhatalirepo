using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_1 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject enemy_Bullet, spec_bullet, nuc_bomb;
    [SerializeField]
    private Transform attack_Point, attack_Point2, attack_Point3, attack_Point4, attack_Point5;
    public int health;
    public GameObject ExplosionEffect;
    public bool bulletsStart = false;


    public bool attacker;
    //public GameObject PlayerBulletGO;
    
    public GameObject BulletPosition;
    public GameObject BulletPosition_2;
    void Start()
    {
        if (attacker == true)
        StartCoroutine(BulletCoroutine());
        Invoke("bulletT",3f);
    }

    // Update is called once per frame
    void Update()
    {
        //explosion mermi isabet
        if (health <= 0 )
        {
             Instantiate(ExplosionEffect, transform.position, transform.rotation);

             Destroy(gameObject);
        }
    }

//  IEnumerator BulletCoroutine()
//     {
//         while (true)
//         {
//         //GameObject bullet01 = (GameObject)Instantiate (PlayerBulletGO);
//         bullet01.transform.position = BulletPosition.transform.position;
//         yield return new WaitForSeconds(0.5f);
//         }
        
        


//     }




IEnumerator BulletCoroutine() // bullet position
      {
        while(true)
        {
            if (bulletsStart == true)
            {
                Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point2.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point3.position, Quaternion.Euler(0,0,-90));
                



            }
            yield return new WaitForSeconds(2f);
        }
        
      } 




// mermi çarpışma
     void OnCollisionEnter2D(Collision2D other) 
    {

        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Yarraaenemy");
            health -= 1 ;
           //Destroy(gameObject);
        }
         if (other.gameObject.CompareTag("Player"))
         {
            Debug.Log("Player'a carptik");
             health -= 1 ;
         }
        
    }
    void bulletT()
    {
        bulletsStart = true;
    }


    // void Die()
    // {
    //     GetComponent<LootBag>().InstantiateLoot(transform.position);
    //     Destroy(gameObject);
    // }

    
}