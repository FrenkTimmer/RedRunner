using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RedRunner.Enemies;
using RedRunner.Characters;

public class FallingSaw : Enemy
{
    [SerializeField]
    protected Collider2D m_Collider2D;

    private float lifeTime;
    private float maxLifeTime = 5f;
    public float moveSpeed = 30f;

    public override Collider2D Collider2D
    {
        get
        {
            return m_Collider2D;
        }
    }

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

    private void OnEnable()
    {
        lifeTime = 0f;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifeTime)
        {
            SawPool.Instance.ReturnToPool(this);
        }
        if (FindObjectOfType<RedCharacter>().IsDead.Value)
        {
            SawPool.Instance.ReturnToPool(this);
        }
    }
}
