using RedRunner.Characters;
using RedRunner.Collectables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flag : Collectable
{
    public string pickUpButton = "f";
    public bool stateSet = false;
    public bool pickedUp = false;

    private void Awake()
    {
      //  playerStateManager.GetComponent<PlayerStateManager>();
    }

    public override SpriteRenderer SpriteRenderer => throw new System.NotImplementedException();

    public override Collider2D Collider2D => throw new System.NotImplementedException();

    public override Animator Animator => throw new System.NotImplementedException();

    public override bool UseOnTriggerEnter2D { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void Collect()
    {
        throw new System.NotImplementedException();
    }

    public override void OnCollisionEnter2D(Collision2D collision2D)
    {
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown(pickUpButton) && pickedUp == false)
        {
            Invoke("SetTrue", 0.3f);
            AttachFlag();
        }
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
    }

    public void AttachFlag()
    {
        stateSet = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        FindObjectOfType<RedCharacter>().m_PutFlagDown = false;
        gameObject.transform.position = GameObject.FindGameObjectWithTag("Hand").transform.position;
        gameObject.transform.parent = GameObject.FindGameObjectWithTag("Hand").transform;
    }

    private void Update()
    {
        if(Input.GetButtonDown(pickUpButton) && pickedUp == true)
        {
            DetachFlag();
        }
    }

    public void DetachFlag()
    {
        if(stateSet == false)
        {
            GameObject.FindObjectOfType<PlayerStateManager>().SetPlayerState(GameObject.FindGameObjectWithTag("Player").transform.position);
            FindObjectOfType<RedCharacter>().m_PutFlagDown = true;
            pickedUp = false;
            gameObject.GetComponent<Collider2D>().enabled = true;
            gameObject.transform.parent = null;
            gameObject.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
            stateSet = true;
        }
      
    }
    public void SetTrue()
    {
        pickedUp = true;
    }
    

}
