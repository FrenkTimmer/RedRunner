using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RedRunner.Characters;

public class SawPooled : MonoBehaviour
{

    [SerializeField]
    private float spawnRate = 2f;
    private float spawnRateTimer = 0;
    private float triggerTimer = 0;
    private float triggerTime = 5f;
    public bool allowedToSpawn = false;
   
    void Start()
    {
        
    }

    void Update()
    {
        SpawnTiming();
    }

    private void Spawn()
    {
        var saw = SawPool.Instance.Get();
        saw.transform.rotation = transform.rotation;
        saw.transform.position = new Vector3(transform.position.x, transform.position.y + UnityEngine.Random.Range(-10f, 10f), 0);
        saw.gameObject.SetActive(true);
    }

    private void SpawnTiming()
    {
        if (FindObjectOfType<RedCharacter>().IsDead.Value)
        {
            allowedToSpawn = false;
        }
        if (allowedToSpawn)
        {
            triggerTimer += Time.deltaTime;
            spawnRateTimer += Time.deltaTime;
        }
        if(triggerTimer >= triggerTime)
        {
            allowedToSpawn = false;
        }
        
        if (spawnRateTimer >= spawnRate)
        {
            spawnRateTimer = 0;
            Spawn();
        }
    }

    public void StartSpawning()
    {
        spawnRateTimer = 0;
        triggerTimer = 0;
        allowedToSpawn = true;
    }


}
