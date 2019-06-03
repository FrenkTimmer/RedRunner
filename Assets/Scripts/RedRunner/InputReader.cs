using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader: MonoBehaviour
{
    public Vector3 ReadInput()
    {
        return Vector3.zero;
    }

    internal bool ReadUndo()
    {
        return Input.GetKey(KeyCode.Backspace);
    }
}
