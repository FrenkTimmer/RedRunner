using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CareTaker : MonoBehaviour
{
    private Memento memento;

    public Memento Memento
    {
        get { return memento; }
        set { memento = value; }
    }
}
