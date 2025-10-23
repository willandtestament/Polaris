using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("EnemySpawner").GetComponent<SpawnEnemies>().wave == 71){ //check if wave is 71 (game has been won)
            Destroy(GameObject.Find("Player(Clone)")); //destroy player
            Invoke("win", 1); //win
        }
    }
    

    void win(){
        GameObject.Find("YouWin").GetComponent<Renderer>().enabled = true; //display win text
    }
}
