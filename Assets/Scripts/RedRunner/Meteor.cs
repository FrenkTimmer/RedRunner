using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float moveSpeed = 30f;

    private float lifeTime;
    private float maxLifeTime = 5f;

    private void OnEnable()
    {
        lifeTime = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if(lifeTime > maxLifeTime)
        {
            MeteorPool.Instance.ReturnToPool(this);
        }
    }
}
