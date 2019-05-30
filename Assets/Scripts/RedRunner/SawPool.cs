using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawPool : MonoBehaviour
{

    [SerializeField] private FallingSaw saw;
    private Queue<FallingSaw> saws = new Queue<FallingSaw>();
    public static SawPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public FallingSaw Get()
    {
        if (saws.Count == 0)
        {
            AddSaws(1);
        }

        return saws.Dequeue();
    }

    private void AddSaws(int count)
    {
        FallingSaw sawInstance = Instantiate(saw);
        sawInstance.gameObject.SetActive(false);
        saws.Enqueue(sawInstance);
    }

    public void ReturnToPool(FallingSaw saw)
    {
        saw.gameObject.SetActive(false);
        saws.Enqueue(saw);
    }

}
