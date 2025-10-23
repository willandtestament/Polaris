using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    //define variables
    public Transform enemybulletspawnpoint;
    public GameObject enemybulletprefab;
    public float enemybulletspeed = 10;
    public float enemyshootTimer = 0;
    public float enemyshootdelay = 1;
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
            }
        }
    }
}
