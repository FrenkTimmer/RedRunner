using RedRunner.Characters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedHat : HeadDecorator
{
    public float speed;
    public RedCharacter redChar;

    public SpeedHat(BaseHead head, float speed) : base(head)
    {
        this.speed = speed;
    }

    public void ChangeSpeed()
    {
        redChar = FindObjectOfType<RedCharacter>();
        if (redChar.m_RunSpeed < 15)
        {
            redChar.m_RunSpeed += speed;
        }
    }


    public override void Use()
    {
        Debug.Log("SpeedHat");
        ChangeSpeed();
    }
}
