using RedRunner.Characters;
using RedRunner.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimmedom : Enemy
{
    EnemyFSM dimmedomMode = EnemyFSM.Idle;

    public Dimmedom(Transform dimmedomObj)
    {
        base.enemyObj = dimmedomObj;
    }

    public override Collider2D Collider2D => throw new System.NotImplementedException();

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Character character = collision2D.collider.GetComponent<Character>();
        if (character != null)
        {
            Kill(character);
        }
    }

    public override void Kill(Character target)
    {
        target.Die(true);
    }


    //Update the creeper's state
    public override void UpdateEnemy(Transform playerObj)
    {
        //The distance between the Creeper and the player
        float distance = (base.enemyObj.position - playerObj.position).magnitude;
        Debug.Log(distance);

        switch (dimmedomMode)
        {
            case EnemyFSM.Attack:

                enemyObj.rotation = Quaternion.LookRotation(playerObj.position - enemyObj.position);
                enemyObj.Translate(enemyObj.forward * 1f * Time.deltaTime);

                if (distance > 5f)
                {
                    dimmedomMode = EnemyFSM.Idle;
                }

                

                break;

            case EnemyFSM.Idle:
                if (distance < 5f)
                {
                    dimmedomMode = EnemyFSM.Attack;
                }
                break;
        }

        //Move the enemy based on a state
        DoAction(playerObj, dimmedomMode);
    }
}
