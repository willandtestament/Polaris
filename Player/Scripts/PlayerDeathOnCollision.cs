using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){ //detect collision
        if (collision.gameObject.tag == "Enemy"){ //if collision is enemy
            if (GameObject.Find("PowerupController").GetComponent<powerups>().phaseShiftActive == false){ //if phase shift is inactive
                Destroy(gameObject); //destroy the player
            }
        }
    }
}
