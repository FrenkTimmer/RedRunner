using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawPooled : MonoBehaviour
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
        var saw = SawPool.Instance.Get();
        saw.transform.rotation = transform.rotation;
        saw.transform.position = new Vector3(transform.position.x, transform.position.y + UnityEngine.Random.Range(-10f, 10f), 0);
        saw.gameObject.SetActive(true);
    }
}
