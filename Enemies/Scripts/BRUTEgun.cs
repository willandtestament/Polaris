using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRUTEgun : MonoBehaviour
{
    //define variables
    public Transform spawnpointa;
    public Transform spawnpointb;
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
            var enemybullet = Instantiate(enemybulletprefab, spawnpointa.position, spawnpointa.rotation);
            //add velocity
            enemybullet.GetComponent<Rigidbody>().velocity = spawnpointa.forward * enemybulletspeed;
            //instantiate bullet
            var enemybullet2 = Instantiate(enemybulletprefab, spawnpointb.position, spawnpointb.rotation);
            //add velocity
            enemybullet2.GetComponent<Rigidbody>().velocity = spawnpointb.forward * enemybulletspeed;
            }
        }
    }
}
