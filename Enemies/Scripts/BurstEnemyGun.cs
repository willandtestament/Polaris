using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstEnemyGun : MonoBehaviour
{
    //define variables
    public Transform enemybulletspawnpoint;
    public GameObject enemybulletprefab;
    public float enemybulletspeed = 10;
    public float enemyshootTimer = 0;
    public float enemyshootdelay = 3;
    public float delaybetweenshots = 0.5f;
    public bool secondshot = false;
    void Update()
    {
        //time comparison
        enemyshootTimer += Time.deltaTime;
        if (enemyshootTimer > enemyshootdelay){
            if (GameObject.Find("PowerupController").GetComponent<powerups>().phaseShiftActive == false){
            enemyshootTimer = 0;
            //instantiate bullet
            var enemybullet = Instantiate(enemybulletprefab, enemybulletspawnpoint.position, enemybulletspawnpoint.rotation);
            //add velocity
            enemybullet.GetComponent<Rigidbody>().velocity = enemybulletspawnpoint.forward * enemybulletspeed;
            secondshot = true;
        }
        }
        if (enemyshootTimer > delaybetweenshots){
            if (secondshot == true){ //check second shot
                if (GameObject.Find("PowerupController").GetComponent<powerups>().phaseShiftActive == false){ //check if phase shift isnt false
                //create bullet
                var enemybullet = Instantiate(enemybulletprefab, enemybulletspawnpoint.position, enemybulletspawnpoint.rotation);
                //add velocity
                enemybullet.GetComponent<Rigidbody>().velocity = enemybulletspawnpoint.forward * enemybulletspeed;
                secondshot = false;
                }
            }
        
        }
    }
}
