using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memento : MonoBehaviour
{
    private Vector2 playerState;

    public Memento(Vector2 state)
    {
        this.playerState = state;
    }

    public Vector2 PlayerState
    {
        get { return playerState; }
    }
}
