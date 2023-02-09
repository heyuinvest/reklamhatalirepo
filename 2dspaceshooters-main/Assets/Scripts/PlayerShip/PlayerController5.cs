using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController5 : MonoBehaviour
{

    [SerializeField]
    private GameObject player_Bullet, player_BulletR, player_BulletL, spec_bullet, nuc_bomb;
    [SerializeField]
    private Transform attack_Point, Pattack_point1, Pattack_point2, Pattack_point3, Pattack_point4, Pattack_point5, Pattack_point6, Pattack_point7, TwoCrossAttackPointL, TwoCrossAttackPointR;
    public bool Crossfire;
    public bool powBullet = false;
    public int bulletsStart;
    public int bulletFull;
    public int bulletCount;
    public int bulletsdouble;
    public int bulletstriple;
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

public static float sattackDenS5;
    void Start()
    {
if (PlayerPrefs.HasKey("shipAttackDens"))
        {
            sattackDenS5 = PlayerPrefs.GetFloat("shipAttackDens");
        }
        else
            sattackDenS5 = 0.5f;
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

        if (health <= 0 && updateController == 0)
        {
            Instantiate(ExplosionEffect, transform.position, transform.rotation);

            //Destroy(gameObject);


            updateController = 1;
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
        while (true)
        {
       if (SFXManager.sfxInstance.musicToggle == 1)
                SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.PlayerLaser);
            if (bulletCount == 1 && Crossfire == true  && powBullet == false)
            {
                Instantiate(player_Bullet, attack_Point.position, Quaternion.Euler(0,0,90));
                
                



            }
            if (bulletCount == 2 && Crossfire == true  && powBullet == false)
            {
                Instantiate(player_Bullet, TwoCrossAttackPointL.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, TwoCrossAttackPointR.position, Quaternion.Euler(0,0,90));
                

                
                



            }

            if (Crossfire == true && bulletCount >= 3 && powBullet == false)
            {
                Instantiate(player_Bullet, attack_Point.position, Quaternion.Euler(0, 0, 90));
                Instantiate(player_BulletR, TwoCrossAttackPointL.position, Quaternion.Euler(0, 0, 90));
                Instantiate(player_BulletL, TwoCrossAttackPointR.position, Quaternion.Euler(0, 0, 90));
            }

            if (Crossfire == true && bulletCount >= 4 && powBullet == false)
            {
                Instantiate(player_Bullet, attack_Point.position, Quaternion.Euler(0, 0, 90));

                Instantiate(player_Bullet, TwoCrossAttackPointL.position, Quaternion.Euler(0, 0, 90));
                Instantiate(player_Bullet, TwoCrossAttackPointR.position, Quaternion.Euler(0, 0, 90));

                Instantiate(player_BulletR, TwoCrossAttackPointL.position, Quaternion.Euler(0, 0, 90));
                Instantiate(player_BulletL, TwoCrossAttackPointR.position, Quaternion.Euler(0, 0, 90));
            }
            // if (bulletCount == 2 && powBullet == false)
            // {
            //     Instantiate(player_Bullet, Dattack_point1.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, Dattack_point2.position, Quaternion.Euler(0,0,90));





            // }


            // if (bulletCount == 3 && powBullet == false)
            // {
            //     Instantiate(player_Bullet, Tattack_point1.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, Tattack_point2.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, Tattack_point3.position, Quaternion.Euler(0,0,90));





            // }
            // if (bulletCount == 4 && powBullet == false)
            // {
            //     Instantiate(player_Bullet, Fattack_point1.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, Fattack_point2.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, Fattack_point3.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, Fattack_point4.position, Quaternion.Euler(0,0,90));





            // }
            // if (bulletCount == 5 && powBullet == false)
            // {
            //     Instantiate(player_Bullet, attack_Point.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, attack_Point2.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, attack_Point3.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, attack_Point4.position, Quaternion.Euler(0,0,90));
            //     Instantiate(player_Bullet, attack_Point5.position, Quaternion.Euler(0,0,90));



            // }
            if (powBullet == true)
            {
                Instantiate(player_Bullet, Pattack_point1.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point2.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point3.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point4.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point5.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point6.position, Quaternion.Euler(0,0,90));
                Instantiate(player_Bullet, Pattack_point7.position, Quaternion.Euler(0,0,90));
            }
           

            



            yield return new WaitForSeconds(sattackDenS5);
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
            Debug.Log("Bullet 1 arttý");
            bulletCount += 1;

        }
        if (other.gameObject.CompareTag("PobUpgrade"))
        {
            Debug.Log("Bullet 17 arttý");
            powBullet = true;

        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy'e carpti");
            health -= 1;
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
            Debug.Log("Bullet 1 arttý");
            bulletCount += 1;
        }
        if (other.gameObject.CompareTag("PobUpgrade"))
        {
            Debug.Log("powBullet Alýndý");
            powBullet = true;
        }
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Debug.Log("Player Damage Aldý");
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
