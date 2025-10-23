using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class EnemyBullet : MonoBehaviour
{
    //define a lifespan
    public float life = 3;
    //on initiation
    void Awake()
    {
        //destroy after time (improves performance and ensures lag is minimised)
        Destroy(gameObject, life);
    }
    //detect when bullet collides
    void OnCollisionEnter(Collision collision)

    {
        //if object is tagged as an player
        if (collision.gameObject.tag == "Player")
        {
            //destroy it and the bullet
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boundary") //check if boundary
        {
            //destroy the bullet
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "PlayerBullet") //check if player bullet
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }
}