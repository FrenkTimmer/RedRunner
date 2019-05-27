using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorPooled : MonoBehaviour
{

    [SerializeField]
    private float spawnRate = 2f;
    private float spawnTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate)
        {
            spawnTimer = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        var met = MeteorPool.Instance.Get();
        met.transform.rotation = transform.rotation;
        met.transform.position = new Vector3(transform.position.x + UnityEngine.Random.Range(-10f, 10f), transform.position.y, 1);
        met.gameObject.SetActive(true);
    }
}
