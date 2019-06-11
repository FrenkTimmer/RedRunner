using RedRunner.Characters;
using RedRunner.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    public GameObject playerObj;
    //A list that will hold all enemies
    public List<Enemy> enemies = new List<Enemy>();

    private void Start()
    {
        Invoke("AddEnemies",1f);
    }

    public void ResetEnemy()
    {
        Debug.Log("RESET");
        Invoke("AddEnemies", 0f);
    }

    public void AddEnemies()
    {
        enemies.Clear();
        foreach (var dom in GameObject.FindObjectsOfType<Dimmedom>())
        {
            enemies.Add(new Dimmedom(dom.transform));
        }
    }


    void Update()
    {
        //Update all enemies to see if they should change state and move/attack player
        for (int i = 0; i < enemies.Count; i++)
        {
           // if (enemies[i] != null)
            enemies[i].UpdateEnemy(playerObj.transform);
        }
    }
}

