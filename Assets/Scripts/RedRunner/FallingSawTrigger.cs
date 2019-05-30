using RedRunner.Characters;
using RedRunner.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FallingSawTrigger : Enemy
{
    [SerializeField]
    private Collider2D m_Collider2D;

    public override Collider2D Collider2D
    {
        get
        {
            return m_Collider2D;
        }
    }

    public override void Kill(Character target)
    {
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.collider.CompareTag("Player"))
        {
            FindObjectOfType<SawPooled>().StartSpawning();
        }
    }
}
