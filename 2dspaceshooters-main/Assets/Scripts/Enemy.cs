using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject enemy_Bullet, spec_bullet, nuc_bomb;
    [SerializeField]
    private Transform attack_Point, attack_Point2, attack_Point3, attack_Point4, attack_Point5;
    public int health;
    public GameObject ExplosionEffect;
    //public bool bulletsStart = true;
    public int bulletLevel;
    public int randomNumber ;
    public GameObject Upgrades;
    


    public bool attacker;
    //public GameObject PlayerBulletGO;
    
    public GameObject BulletPosition;
    public GameObject BulletPosition_2;

    public GameObject[] itemDrops;
    void Start()
    {
        Upgrades.SetActive(false);
        randomNumber = Random.Range(1,25);
        if (attacker == true)
        
        Invoke("bulletT", randomNumber);
        
    }

    // Update is called once per frame
    void Update()
    {
        //explosion mermi isabet
        if (health <= 0 )
        {
             Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Upgrades.SetActive(true);
             Destroy(gameObject);
             if (SFXManager.sfxInstance.musicToggle == 1)
                SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.ExplosionSound);

            ItemDrop();
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
            // if (bulletsStart == true)
            // {
            //     Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
            //     Instantiate(enemy_Bullet, attack_Point2.position, Quaternion.Euler(0,0,-90));
            //     Instantiate(enemy_Bullet, attack_Point3.position, Quaternion.Euler(0,0,-90));
                



            // }
            if (bulletLevel == 1)
            {
                Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
            }
            if (bulletLevel == 2)
            {
                Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point2.position, Quaternion.Euler(0,0,-90));
            }
            if (bulletLevel == 3)
            {
                Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point2.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point3.position, Quaternion.Euler(0,0,-90));
            }
            if (bulletLevel == 4)
            {
                Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point2.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point3.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point4.position, Quaternion.Euler(0,0,-90));
            }
            if (bulletLevel == 5)
            {
                Instantiate(enemy_Bullet, attack_Point.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point2.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point3.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point4.position, Quaternion.Euler(0,0,-90));
                Instantiate(enemy_Bullet, attack_Point5.position, Quaternion.Euler(0,0,-90));
            }
            yield return new WaitForSeconds(randomNumber);
        }
        
      } 




// mermi çarpışma
     void OnCollisionEnter2D(Collision2D other) 
    {

        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            
            health -= 1 ;
           //Destroy(gameObject);
        }
         if (other.gameObject.CompareTag("DroneBullet"))
        {
            
            health -= 1 ;
           //Destroy(gameObject);
        }
         if (other.gameObject.CompareTag("Player"))
         {
            
             health -= 1 ;
         }
         if (other.gameObject.CompareTag("Drone"))
         {
            
             health -= 1 ;
         }
        
    }
    void bulletT()
    {
        
        StartCoroutine(BulletCoroutine());
    }


    // void Die()
    // {
    //     GetComponent<LootBag>().InstantiateLoot(transform.position);
    //     Destroy(gameObject);
    // }

    private void ItemDrop()
    {
        for(int i = 0; i < itemDrops.Length; i++)
        {
            Instantiate(itemDrops[i], transform.position + new Vector3(0,1,0), Quaternion.identity);
        }
    }
}
