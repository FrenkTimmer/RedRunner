using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memento : MonoBehaviour
{
    private Vector2 playerStateLocation;

    public Memento(GameObject state)
    {
        this.playerStateLocation = state.transform.position;
    }

    public Vector2 PlayerState
    {
        get { return playerStateLocation; }
    }
}
