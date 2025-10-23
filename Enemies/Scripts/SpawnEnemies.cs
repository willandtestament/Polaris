using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    //define variables
    public bool enemychecked = false;
    public GameObject defaultenemy;
    public GameObject burstenemy;
    public GameObject minienemy;
    public GameObject rapidfireenemy;
    public GameObject brute;
    public GameObject boss;
    public int wave;
   
    // Start is called before the first frame update
    void Start()
    {
        wave = 0; //set wave to zero
    }

    void Update()
    {
        GameObject[] gameObjects; //make array of gameobjects
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy"); //find enemies
        if (gameObjects.Length == 0){ //if no enemies
            Debug.Log("No enemies found!"); //log
            if (GameObject.Find("PowerupController").GetComponent<powerups>().phaseShiftActive == false){ //check if phase shift is not enabled
            if (enemychecked == false){ //debounce check
                if (wave < 71){ //check if wave is under 71
                wave ++; //increment wave
                if (wave == 70){ //check if wave is 70
                    Invoke("spawnboss", 1); //spawn boss
                    enemychecked = true; //reset debounce 
                }
                else if (wave > 70){ //check if wave greater than 70
                    Debug.Log("Game Finished!"); //log
                }
                else{
                    //random spawns
                float pattern = Random.Range(1, 9);
                if (pattern == 1){
                    Invoke("DefaultSpawn", 1);
                    enemychecked = true; 
                }
                if (pattern == 2){
                    Invoke("checkerboard", 1);
                    enemychecked = true; 
                }
                if (pattern == 3){
                    Invoke("rapidrumble", 1);
                    enemychecked = true; 
                }
                if (pattern == 4){
                    Invoke("BRUTEspawn", 1);
                    enemychecked = true; 
                }
                if (pattern == 5){
                    Invoke("everything", 1);
                    enemychecked = true; 
                }
                if (pattern == 6){
                    Invoke("burstbonanza", 1);
                    enemychecked = true; 
                }
                if (pattern == 7){
                    Invoke("headerandfooter", 1);
                    enemychecked = true; 
                }
                if (pattern == 8){
                    Invoke("manymini", 1);
                    enemychecked = true; 
                }
                }
                }
            }
              
            }
        }
    }
    //spawning patterns
    void DefaultSpawn()
    {
        Instantiate(defaultenemy, new Vector3(-8.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(-6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(defaultenemy, new Vector3(8.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        enemychecked = false;
    }

    void checkerboard()
    {

        //row1
        Instantiate(minienemy, new Vector3(-2.0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-4.0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-6.0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(2.0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(4.0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(6.0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        //row2
        Instantiate(minienemy, new Vector3(-3.0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-1.0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-5.0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(1.0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(3.0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(5.0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        //row3
        Instantiate(minienemy, new Vector3(-2.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-4.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(2.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(4.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        //row4
        Instantiate(minienemy, new Vector3(-3.0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-1.0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-5.0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(1.0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(3.0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(5.0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        enemychecked = false;
    }

    void rapidrumble()
    {
        Instantiate(rapidfireenemy, new Vector3(-8.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(rapidfireenemy, new Vector3(0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(rapidfireenemy, new Vector3(8.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        enemychecked = false;
    }

    void BRUTEspawn()
    {
        Instantiate(brute, new Vector3(-6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0,0,0)));
        Instantiate(brute, new Vector3(6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0,0,0)));
        enemychecked = false;
    }
    void everything()
    {
        Instantiate(brute, new Vector3(0f, 2.0f, 9.0f), Quaternion.Euler(new Vector3(0,0,0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 5.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(-1.0f, 2.0f, 5.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(1.0f, 2.0f, 5.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(defaultenemy, new Vector3(-8.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(-6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(6.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(defaultenemy, new Vector3(8.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(rapidfireenemy, new Vector3(4.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(rapidfireenemy, new Vector3(-4.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        enemychecked = false;
    }

    void burstbonanza()
    {
        Instantiate(burstenemy, new Vector3(-4.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(-2.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(2.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        Instantiate(burstenemy, new Vector3(4.0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(90,0,0)));
        enemychecked = false;
    }

    void headerandfooter()
    {
       Instantiate(rapidfireenemy, new Vector3(-8.0f, 2.0f, 10.0f), Quaternion.Euler(new Vector3(90,0,0)));
       Instantiate(rapidfireenemy, new Vector3(-6.0f, 2.0f, 10.0f), Quaternion.Euler(new Vector3(90,0,0)));
       Instantiate(rapidfireenemy, new Vector3(-4.0f, 2.0f, 10.0f), Quaternion.Euler(new Vector3(90,0,0))); 
       Instantiate(rapidfireenemy, new Vector3(-2.0f, 2.0f, 10.0f), Quaternion.Euler(new Vector3(90,0,0))); 
       ////////////////////////////////////////////////////////////////////////////////////////////////////
       Instantiate(rapidfireenemy, new Vector3(8.0f, 2.0f, -3.0f), Quaternion.Euler(new Vector3(90,0,180)));
       Instantiate(rapidfireenemy, new Vector3(6.0f, 2.0f, -3.0f), Quaternion.Euler(new Vector3(90,0,180)));
       Instantiate(rapidfireenemy, new Vector3(4.0f, 2.0f, -3.0f), Quaternion.Euler(new Vector3(90,0,180)));
       Instantiate(rapidfireenemy, new Vector3(2.0f, 2.0f, -3.0f), Quaternion.Euler(new Vector3(90,0,180)));
       enemychecked = false;
    }

    void manymini()
    {
        Instantiate(minienemy, new Vector3(0f, 2.0f, -1.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 1.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 2.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 3.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 4.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 5.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 6.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        Instantiate(minienemy, new Vector3(0f, 2.0f, 8.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        enemychecked = false;
    }

    void spawnboss(){ //chaos catastrophe
        Instantiate(boss, new Vector3(0f, 2.0f, 7.0f), Quaternion.Euler(new Vector3(0, 180, 0)));
        enemychecked = false;
    }

}



































































































































































































































































































































































































































































































































































































































































































































































































































































































//:3333333333