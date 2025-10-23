using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Bullet : MonoBehaviour
{
    //define a lifespan
    public float life = 3;
    public bool debounce = false;
    //on initiation
    void Awake()
    {
        //destroy after time (improves performance and ensures lag is minimised)
        Destroy(gameObject, life);
    }
    //detect when bullet collides
    void OnCollisionEnter(Collision collision)

    {
        //if object is tagged as an enemy
        if (collision.gameObject.tag == "Enemy")
        {
            if (debounce == false){ //check debounce
                if (GameObject.Find("PowerupController").GetComponent<powerups>().isPolar == true){ //check polarity
                    debounce = true; //reset debounce
                    Debug.Log("Enemy hit!");//log for debugging purposes
                    collision.gameObject.GetComponent<EnemyHealth>().Health -=2; //deal double damage
                    Destroy(gameObject); //destory the bullet
                    if (collision.gameObject.GetComponent<EnemyHealth>().Health <= 0){ //check enemy health
                        Destroy(collision.gameObject); //destroy enemy
                    }  
                }
                else{
                    debounce = true; //reset debounce
                    Debug.Log("Enemy hit!"); //log for debugging
                    collision.gameObject.GetComponent<EnemyHealth>().Health -=1; //deal single damage
                    Destroy(gameObject); //destroy bullet
                    if (collision.gameObject.GetComponent<EnemyHealth>().Health <= 0){ //check enemy health
                        Destroy(collision.gameObject); //destroy enemy
                    }
                }
            }
            
        }
//remove bullets when hit wall
        if (collision.gameObject.tag == "Boundary") //check if boundary
        {
            //destroy the bullet
            Destroy(gameObject);
        }





    }
}