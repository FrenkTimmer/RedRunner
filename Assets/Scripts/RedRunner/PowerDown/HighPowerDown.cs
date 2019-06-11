using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighPowerDown : PowerDown
{
    private float speedValue = 4;
    private float jumpValue = 0;
    private float timeValue = 5;

    public override SpriteRenderer SpriteRenderer => throw new System.NotImplementedException();

    public override Collider2D Collider2D => throw new System.NotImplementedException();

    public override void Activate()
    {
        SpeedDecrease(speedValue);
        JumpDecrease(jumpValue);
        SetDuration(timeValue);
    }
}
