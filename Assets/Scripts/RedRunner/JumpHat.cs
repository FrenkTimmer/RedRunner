using RedRunner.Characters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHat : HeadDecorator
{
    public float jumpHeight;
    public RedCharacter redChar;

    public JumpHat(BaseHead head, float jumpHeight) : base(head)
    {
        this.jumpHeight = jumpHeight;
    }

    public void ChangeJumpHeight()
    {
        redChar = FindObjectOfType<RedCharacter>();
        if(redChar.m_JumpStrength < 20)
        {
            redChar.m_JumpStrength += jumpHeight;
        }
    }

    public override void Use()
    {
        Debug.Log("JumpHat");
        ChangeJumpHeight();
    }
}
