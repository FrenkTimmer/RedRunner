using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    private static PlayerStateManager singleton;
    Originator originator = new Originator();
    CareTaker careTaker = new CareTaker();

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
        
    }

    public void SetPlayerState(GameObject player)
    {
        originator.PlayerState = player;
        careTaker.Memento = originator.CreateMemento();
    }

    public void RestorePlayerState()
    {
       originator.SetMemento(careTaker.Memento);
    }
}
