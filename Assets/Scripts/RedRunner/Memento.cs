using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memento : MonoBehaviour
{
    private GameObject playerState;

    public Memento(GameObject state)
    {
        this.playerState = state;
    }

    public GameObject PlayerState
    {
        get { return playerState; }
    }
}
