using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float lifetime;

    public float bombOrFruit;

    public GameObject particleObject;
    void Start()
    {
        rb.velocity = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
        );

        Destroy(gameObject, lifetime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cut")
        {
            if(bombOrFruit == 0)
            {
                GameObject gameObject = Instantiate(particleObject, transform.position, transform.rotation);

            }


        }
    }
}
