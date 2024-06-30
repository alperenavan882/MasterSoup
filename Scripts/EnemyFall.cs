using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFall : MonoBehaviour
{
    public float enemySpeed;
    //public GameObject explos;

    

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.down * enemySpeed);
        Vector2 parentPos = GetComponent<Transform>().position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        

        
    }
}
