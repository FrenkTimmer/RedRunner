using RedRunner.Characters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerDown : MonoBehaviour
{

    public abstract SpriteRenderer SpriteRenderer { get; }
    public abstract Collider2D Collider2D { get; }
    public abstract void Activate();

    protected RedCharacter redChar;
    protected float upTime = 0;
    protected bool active = false;
    protected float preciousSpeed;
    protected float preciousJump;

    private void Start()
    {
        redChar = FindObjectOfType<RedCharacter>();
        preciousSpeed = redChar.m_RunSpeed;
        preciousJump = redChar.m_JumpStrength;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(active == false)
        {
            StartCoroutine(StartPowerDown(upTime));
        }
        
    }

    protected void SpeedDecrease(float speedDecrease)
    {
        if (active)
        {
            preciousSpeed = redChar.m_RunSpeed;
            redChar.m_RunSpeed -= speedDecrease;
        }
        else
        {
            redChar.m_RunSpeed = preciousSpeed;
        }
        
    }

    protected void JumpDecrease(float jumpDecrease)
    {
        if (active)
        {
            preciousJump = redChar.m_JumpStrength;
            redChar.m_JumpStrength -= jumpDecrease;
        }
        else
        {
            redChar.m_JumpStrength = preciousJump;
        }
    }

    protected void SetDuration(float time)
    {
        upTime = time;
    }

    private IEnumerator StartPowerDown(float waitTime)
    {
        active = true;
        Activate();
        yield return new WaitForSeconds(waitTime);
        active = false;
        Activate();
    }
  

   

}
