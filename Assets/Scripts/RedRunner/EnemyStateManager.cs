using RedRunner.Characters;
using RedRunner.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject dimmedomObj;


    //A list that will hold all enemies
    List<Enemy> enemies = new List<Enemy>();

    private void Start()
    {
        Invoke("AddEnemies",1f);
    }

    void AddEnemies()
    {
    //Add the enemies we have
    
    foreach (var dom in GameObject.FindObjectsOfType<Dimmedom>())
        {
            enemies.Add(new Dimmedom(dom.transform));
        }
    }


    void Update()
    {
        Debug.Log(enemies.Count);
        //Update all enemies to see if they should change state and move/attack player
            for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i].UpdateEnemy(playerObj.transform);
        }
    }
    }

