using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawning : MonoBehaviour
{
    //define variables
    public bool PlayerChecked = false;
    public GameObject Player;
    public GameObject polarobject;
    void Update()
    {
        GameObject[] gameObjects; //new array
        gameObjects = GameObject.FindGameObjectsWithTag("Player"); //add player to it
        if (gameObjects.Length == 0){ //if length of array is 0 (no player)
            Debug.Log("No player found!"); //log for debugging 
            if (PlayerChecked == false){ //check debounce (avoids multiple players)
                PlayerChecked = true; //set debounce
                polarobject.GetComponent<powerups>().isPolar = false; //reset polarity switch
                if (GameObject.Find("EnemySpawner").GetComponent<SpawnEnemies>().wave != 71){ //ensure player hasnt won already
                Debug.Log("Spawning player!"); //log
                Invoke("SpawnPlayer", 1); //respawn the player
                Invoke("DestroyAllBullets", 1); //destroy every bullet
                }
            }
        }
    }
    void SpawnPlayer(){
        Instantiate(Player, new Vector3(0f, 2.0f, -7.7f), Quaternion.Euler(new Vector3(0,270,90))); //instantiate new player from prefab
        PlayerChecked = false; //reset debounce
    }

    void DestroyAllBullets(){
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("EnemyBullet")){ //find all enemy bullets
            Destroy(gameObj); //destroy them
        }
    }
}






