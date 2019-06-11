using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowPowerDown : PowerDown
{
    private float speedValue = 1;
    private float jumpValue = 10;
    private float timeValue = 2;

    public override SpriteRenderer SpriteRenderer => throw new System.NotImplementedException();

    public override Collider2D Collider2D => throw new System.NotImplementedException();

    public override void Activate()
    {
        SpeedDecrease(speedValue);
        JumpDecrease(jumpValue);
        SetDuration(timeValue);
    }
}
