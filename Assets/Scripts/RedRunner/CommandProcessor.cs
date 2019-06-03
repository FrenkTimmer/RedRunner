using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    private List<Command> _commands = new List<Command>();
    private int _currentCommandIndex;

    public void Undo()
    {
        if (_currentCommandIndex < 0)
            return;

        _commands[_currentCommandIndex].Undo();
        _commands.RemoveAt(_currentCommandIndex);
        _currentCommandIndex--;
    }
}
