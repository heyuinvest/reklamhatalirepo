using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

   

    [SerializeField]
    private GameObject player_Bullet, spec_bullet, nuc_bomb;
    [SerializeField]
    private Transform attack_Point, attack_Point2, attack_Point3, attack_Point4, attack_Point5,Dattack_point1,Dattack_point2,Tattack_point1,Tattack_point2,Tattack_point3,Fattack_point1,Fattack_point2,Fattack_point3,Fattack_point4,Pattack_point1,Pattack_point2,Pattack_point3,Pattack_point4,Pattack_point5,Pattack_point6,Pattack_point7;
    public bool Crossfire;
    public bool powBullet = false;
    public int bulletsStart;
    public int bulletFull ;
    public int bulletCount;
    public int bulletsdouble;
    public int bulletstriple ;
    public int bulletsfourable;
    // public bool bulletsdouble = false;
    // public bool bulletstriple = false;
    // public bool bulletsfourable = false;
    // public bool bulletsStart = true;
    // public bool bulletFull = false;
    


    public static int updateController;
    //public static bool isGameOver;
    private bool isMoving = false;
    public static int health = 1;
    public static bool fingameship = false;
    public float min_X, max_X;
    public float min_Y, max_Y;
    private Vector3 targetPosition;
    public float speed = 4;
    public GameObject ExplosionEffect;


    public CameraShake cameraShake;

    void Start()
    {
        StartCoroutine(BulletCoroutine());

        bulletCount = 1;

    }

    // Update is called once per frame
    void Update()
    {
        HealthScript.healthAmount = health;

        if (isMoving)
        {
            Move();
        }
        if (powBullet)
        {
            Invoke("powBulletClose", 1.0f);
        }

        
      if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (health <= 0 &&  updateController == 0)
        {
            Instantiate(ExplosionEffect, transform.position, transform.rotation);

            //Destroy(gameObject);
            //isGameOver = true;
            updateController = 1;
            //Time.timeScale = 0;

            Invoke("gOver", 1f);
        }

    }



     





    void SetTargetPosition()
    {
        
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        if (health != 0)
        {
            isMoving = true;
        }

        if (health == 0)
        {
            isMoving = false;
        }

    }

    void Move()
    {
        if (fingameship == false)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position.x > max_X)
        {
            transform.position = new Vector3(max_X, transform.position.y);
        }

        if (transform.position.x < min_X)
        {
            transform.position = new Vector3(min_X, transform.position.y);
        }

        if (transform.position.y > max_Y)
        {
            transform.position = new Vector3(transform.position.x, max_Y);
        }

        if (transform.position.y < min_Y)
        {
            transform.position = new Vector3(transform.position.x, min_Y);
        }

        if (transform.position == targetPosition)
        {
            isMoving = false;
        }



        }
    }

      IEnumerator BulletCoroutine() // bullet position
      {
        while(true)
        {
            if (SFXManager.sfxInstance.musicToggle == 1)
                SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.PlayerLaser);
            if (bulletCount == 1 && powBullet == false)
            {
                Instantiate(player_Bullet, attack_Point.position, Quaternion.Euler(0,0,90));
                
                



            }
            if (bulletCount == 2 && powBullet == false)
            {
                Instantiate(player_Bullet, Dattack_point1.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Dattack_point2.position, Quaternion.Euler(0,0,90));
                
                



            }


            if (bulletCount == 3 && powBullet == false)
            {
                Instantiate(player_Bullet, Tattack_point1.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Tattack_point2.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Tattack_point3.position, Quaternion.Euler(0,0,90));
                
                



            }
            if (bulletCount == 4 && powBullet == false)
            {
                Instantiate(player_Bullet, Fattack_point1.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Fattack_point2.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Fattack_point3.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Fattack_point4.position, Quaternion.Euler(0,0,90));
                
                



            }
            if (bulletCount == 5 && powBullet == false)
            {
                Instantiate(player_Bullet, attack_Point.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, attack_Point2.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, attack_Point3.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, attack_Point4.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, attack_Point5.position, Quaternion.Euler(0,0,90));



            }
            if(powBullet == true)
            {
                Instantiate(player_Bullet, Pattack_point1.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point2.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point3.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point4.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point5.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point6.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point7.position, Quaternion.Euler(0,0,90));
            }
            

            



            
            yield return new WaitForSeconds(0.5f);
        }
        
      } 
    
    void OnCollisionEnter2D(Collision2D other) 
    {

        // if (other.gameObject.CompareTag("EnemyBullet"))
        // {
        //     Debug.Log("Yarraaplayerr");
        //     health -= 1 ;
        // }
        
         if (other.gameObject.CompareTag("BulletUpgrade"))
         {
             Debug.Log("Bullet 1 artt??");
             bulletCount += 1 ;
            
        }
        if (other.gameObject.CompareTag("PobUpgrade"))
         {
             Debug.Log("Bullet 17 artt??");
             powBullet = true ;
            
        }

        if (other.gameObject.CompareTag("Health"))
        {
            health += 1;
            Destroy(gameObject);

        }

        if (other.gameObject.CompareTag("Enemy"))
         {
            Debug.Log("Enemy'e carpti");
            health -= 1 ;
         }
        

    }
    void powBulletClose()
    {
        powBullet = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BulletUpgrade"))
         {
             Debug.Log("Bullet 1 artt??");
             bulletCount += 1 ;
         }
         if (other.gameObject.CompareTag("PobUpgrade"))
         {
             Debug.Log("powBullet Al??nd??");
             powBullet = true;
         }
        if (other.gameObject.CompareTag("Health"))
        {
            health += 1;
            Destroy(gameObject);

        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Debug.Log("Player Damage Ald??");
            health -= 1;

            if (health == 0)
            {
                cameraShake.ShakeIt();

                GetComponent<BoxCollider2D>().enabled = false;
                StartCoroutine(EnableBox(2.0F));
            }
        }
    }

    IEnumerator EnableBox(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GetComponent<BoxCollider2D>().enabled = true;
    }

    void gOver()
    {
        GameManager.isGameOver = true;

        Time.timeScale = 0;
    }
}

