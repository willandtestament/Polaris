using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGun : MonoBehaviour
{
    //define variables
    public Transform enemybulletspawnpoint;
    public Transform enemybulletspawnpoint2;
    public Transform enemybulletspawnpoint3;
    public GameObject enemybulletprefab;
    public float enemybulletspeed = 10;
    public bool charged = true;
    void shootshots(){
        if (GameObject.Find("PowerupController").GetComponent<powerups>().phaseShiftActive == false){
                //instantiate bullet
                var enemybullet = Instantiate(enemybulletprefab, enemybulletspawnpoint.position, enemybulletspawnpoint.rotation);
                //add velocity
                enemybullet.GetComponent<Rigidbody>().velocity = enemybulletspawnpoint.forward * enemybulletspeed;
                //instantiate bullet
                var enemybullet2 = Instantiate(enemybulletprefab, enemybulletspawnpoint2.position, enemybulletspawnpoint2.rotation);
                //add velocity
                enemybullet2.GetComponent<Rigidbody>().velocity = enemybulletspawnpoint2.forward * enemybulletspeed;
                //instantiate bullet
                var enemybullet3 = Instantiate(enemybulletprefab, enemybulletspawnpoint3.position, enemybulletspawnpoint3.rotation);
                //add velocity
                enemybullet3.GetComponent<Rigidbody>().velocity = enemybulletspawnpoint3.forward * enemybulletspeed;
        }
    }
    void recharge(){
        charged = true; //recharge shots
    }
    void Update(){
        if (charged == true){
            charged = false; //reset charge
            //evenly disperse bullets
            Invoke("shootshots", 1);
            Invoke("shootshots", 1.5f);
            Invoke("shootshots", 2);
            Invoke("shootshots", 2.5f);
            Invoke("recharge", 5);
        }
    }    
}
