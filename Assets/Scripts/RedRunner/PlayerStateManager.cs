﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    private static PlayerStateManager singleton;
    Originator originator = new Originator();
    CareTaker careTaker = new CareTaker();
    public GameObject player;
    public Vector2 restoredPlayer;


    #region Singleton
    public static PlayerStateManager Singleton
    {
        get { return singleton; }
    }
    #endregion

    private void Awake()
    {
        singleton = this;
    }
    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void SetPlayerState(GameObject player)
    {
        originator.PlayerState = player;
        this.player = player;
        careTaker.Memento = originator.CreateMemento();
    }

    public void RestorePlayerState()
    {
        originator.RestoreMemento(careTaker.Memento);
        GameObject.FindGameObjectWithTag("Player").transform.position = originator.PlayerState.transform.position;

    }
}
