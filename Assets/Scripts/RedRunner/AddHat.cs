using RedRunner.Collectables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHat : Collectable
{
    public bool isJumphat;
    public bool isSpeedHat;

    BaseHead head;
    JumpHat jumpHat;
    SpeedHat speedHat;


    public override SpriteRenderer SpriteRenderer
    {
        get
        {
            throw new System.NotImplementedException();
        }
    }

    public override Collider2D Collider2D => throw new System.NotImplementedException();

    public override Animator Animator => throw new System.NotImplementedException();

    public override bool UseOnTriggerEnter2D { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void Collect()
    {
        throw new System.NotImplementedException();
    }

    public override void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (isJumphat && !isSpeedHat)
        {
            jumpHat.Use();
            HatAttached();
        }
        if (isSpeedHat && !isJumphat)
        {
            speedHat.Use();
            HatAttached();
        }
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
    }

    void Start()
    {
        head = new RedRunnerHead();
        if (isJumphat && !isSpeedHat)
        {
            jumpHat = new JumpHat(head, 2f);
        }
        if (isSpeedHat && !isJumphat)
        {
            speedHat = new SpeedHat(head, 2f);
        }

    }

    void HatAttached()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.transform.position = GameObject.FindGameObjectWithTag("Head").transform.position;
        gameObject.transform.parent = GameObject.FindGameObjectWithTag("Head").transform;
    }
}
