using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{
    //define variables
    Renderer ren;
    public GameObject shaderobject;
    public bool isPolar;
    public bool polarCharged;
    public bool polarChecked;
    ////////////////////////
    public bool phaseShiftActive;
    public bool phaseShiftCharged;
    public bool phaseShiftChecked;
    ////////////////////////
    public bool timeWarpActive;
    public bool timeWarpCharged;
    public bool timeWarpChecked;
    ///////////////////////
    public GameObject polarnotifier;
    public GameObject phaseShiftnotifier;
    public GameObject timeWarpnotifier;
    // Start is called before the first frame update
    void Start()
    {
        //reset variables
        isPolar = false;
        polarCharged = false;
        polarChecked = false;
        ///////////////////////////
        phaseShiftActive = false;
        phaseShiftCharged = false;
        phaseShiftChecked = false;
        ///////////////////////////
        timeWarpActive = false;
        timeWarpCharged = false;
        timeWarpChecked = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")){ //if q pressed
            Debug.Log("Q key down!"); //log 
            if (polarCharged == true){ //ensure powerup is charged 
                Debug.Log("Switching polarity!"); //log
                polarCharged = false; //reset charge
                foreach (var gameObj in GameObject.FindGameObjectsWithTag("Player")){ //find player
                    ren=gameObj.GetComponent<Renderer>(); //find player's renderer
                    ren.material.color=Color.black; //make it black
                    isPolar = true; //allow other scripts to know it is polar
                    Invoke("endpolar", 10); //give it 10 sec duration
                }
            }   
        }
    if (isPolar == true){ //check if polar
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("PlayerBullet")){ //find player bullets
            ren=gameObj.GetComponent<Renderer>(); //get bullet renderer
            ren.material.color=Color.black; //make it black
        }
    }
    if (phaseShiftActive == true){ //check if phase shift active 
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Enemy")){ //find enemy
            gameObj.GetComponent<Renderer>().enabled = false; //make it invisible
        }
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("PlayerBullet")){ //also find player bullets
            Destroy(gameObj); //destroy them
        }
    }

    if (GameObject.Find("EnemySpawner").GetComponent<SpawnEnemies>().wave >= 2){ //if wave = 20
        if (polarChecked == false){ //debounce check
            polarChecked = true; //reset debounce
            polarCharged = true; //allow polarity switch
            displaypolar(); //inform user
        }
        }  
        if (GameObject.Find("EnemySpawner").GetComponent<SpawnEnemies>().wave >= 4){ //if wave = 40
            if (phaseShiftChecked == false){ //debounce check
                phaseShiftChecked = true; //reset debounce
                phaseShiftCharged = true; //allow phase shift
                displayphase(); //inform user
            }
        }
        if (GameObject.Find("EnemySpawner").GetComponent<SpawnEnemies>().wave >= 6){ //if wave = 60
            if (timeWarpCharged == false){ //debounce check 
                timeWarpChecked = true; //reset debounce
                timeWarpCharged = true; //allow time warp
                displaytime(); //inform user
            }
        }

    if (Input.GetKeyDown("e")){ //if e pressed
        Debug.Log("E Key down!"); //log
        if (phaseShiftCharged == true){ //check if powerup charged
            phaseShiftCharged = false; //uncharge powerup
            phaseShiftActive = true; //allow other scripts to know
            shaderobject.GetComponent<Renderer>().enabled = true; //enable the inverted colour shader
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("EnemyBullet")){ //find all enemy bullets
                Destroy(gameObj); //destroy them
            }
            Invoke("endphaseshift", 7); //7 sec duration
        }
    }

    if (Input.GetKeyDown(KeyCode.LeftShift)){ //if left shift down
        Debug.Log("F key down!"); //log
        if (timeWarpCharged == true){ //check for timewarp charge
            timeWarpCharged = false; //uncharge it
            timeWarpActive = true; //activated
            Time.timeScale = 0.5f; //half game speed
        }
    }

    if (Input.GetKeyUp(KeyCode.LeftShift)){ //if left shift released 
        Debug.Log("F key up!"); //log
        if (timeWarpActive == true){ //check for timewarp active
            timeWarpActive = false; //make it false
            timeWarpCharged = true; //recharge
            Time.timeScale = 1.0f; //normal speed
        }
    }


    }
    void endpolar(){ 
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Player")){ //find player 
            ren=gameObj.GetComponent<Renderer>(); //get renderer
            ren.material.color=Color.white; //make player white
            isPolar = false; //reset variable
            Debug.Log("Resetting polarity!"); //log
            Invoke("polarRecharge", 30); //recharge time
        }
    }
    void polarRecharge(){
        polarCharged = true; //recharge
        displaypolar(); //inform user
    }

    void endphaseshift(){
        phaseShiftActive = false; //reset var
        shaderobject.GetComponent<Renderer>().enabled = false; //revert screen colours
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Enemy")){ //find all enemies
            gameObj.GetComponent<Renderer>().enabled = true; //make them visible
        }
        Invoke("phaseshiftrecharge", 30); //recharge
    }
    void phaseshiftrecharge(){
        phaseShiftCharged = true; //recharge 
        displayphase(); //inform user
    }
    /////////
    void displaypolar(){
        polarnotifier.GetComponent<Renderer>().enabled = true; //make text visible
        Invoke("hidepolar", 2);
    }
    void hidepolar(){
        polarnotifier.GetComponent<Renderer>().enabled = false; //make text invisible
    }

    void displayphase(){
        phaseShiftnotifier.GetComponent<Renderer>().enabled = true; //make text visible
        Invoke("hidephase", 2);
    }
    
    void hidephase(){
        phaseShiftnotifier.GetComponent<Renderer>().enabled = false; //make text invisible
    }


    void displaytime(){
        timeWarpnotifier.GetComponent<Renderer>().enabled = true; //make text visible
        Invoke("hidetime", 2);
    }

    void hidetime(){
        timeWarpnotifier.GetComponent<Renderer>().enabled = false; //make text invisible
    }


}
