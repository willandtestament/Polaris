using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //define variables
    public float delaybetweenmovement = 1;
    public float movementimer = 0;
    public float movementamount = 0.025f;
    // Update is called once per frame
    void Update()
    {
        movementimer += Time.deltaTime; //count time normlaised
        if (movementimer > delaybetweenmovement){ //check if time has passed
            movementimer = 0; //reset timer
            transform.position += new Vector3(movementamount,0,0); //move enemy
        }
    }

    void OnCollisionEnter(Collision collision) //detect collision
    {
        if (collision.gameObject.tag == "Boundary") //if boundary
        {
            Debug.Log("Collision detected!"); //log
            movementamount *= -1; // reverse movement direction
        }
    }
}
