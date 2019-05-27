using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorPool : MonoBehaviour
{

    [SerializeField] private Meteor meteor;
    private Queue<Meteor> meteors = new Queue<Meteor>();
    public static MeteorPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Meteor Get()
    {
        if (meteors.Count == 0)
        {
            AddMeteors(1);
        }

        return meteors.Dequeue();
    }

    private void AddMeteors(int count)
    {
        Meteor meteorInstance = Instantiate(meteor);
        meteorInstance.gameObject.SetActive(false);
        meteors.Enqueue(meteorInstance);
    }

    public void ReturnToPool(Meteor meteor)
    {
        meteor.gameObject.SetActive(false);
        meteors.Enqueue(meteor);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
