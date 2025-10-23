using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Gun : MonoBehaviour
{
    //def variables
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float shootTimer = 0;
    public float shootdelay = 1;
 
    void Update()
    {
        //detect LMB down
        if(Input.GetMouseButton(0))
        {
            shootTimer += Time.deltaTime; //compare shoot times
            if (shootTimer > shootdelay){
                shootTimer = 0; //reset timer
                //create new bullet from the prefab
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                //create velocity
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            }
        }
    }
}

