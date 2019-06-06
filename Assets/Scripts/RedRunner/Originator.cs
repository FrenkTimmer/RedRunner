using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Originator : MonoBehaviour
{
    private GameObject playerState;

    public GameObject PlayerState
    {
        get { return playerState; }
        set
        {
            playerState = value;
            Debug.Log("player state set");
        }
    }

    public Memento CreateMemento()
    {
        return (new Memento(playerState));
    }

    public void SetMemento(Memento memento)
    {
        PlayerState = memento.PlayerState;
    }

}
