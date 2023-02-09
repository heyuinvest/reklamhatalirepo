using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerUpgrades : MonoBehaviour
{
     public GameObject _fwPEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _fwPEnemy.transform.position;
    }
}
