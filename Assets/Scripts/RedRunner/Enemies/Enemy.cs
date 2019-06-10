using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RedRunner.Characters;

namespace RedRunner.Enemies
{

	public abstract class Enemy : MonoBehaviour
	{

		public abstract Collider2D Collider2D { get; }

		public abstract void Kill ( Character target );

        protected Transform enemyObj;

        //The different states the enemy can be in
        protected enum EnemyFSM
        {
            Attack,
            Idle,
        }

        //Update the enemy by giving it a new state
        public virtual void UpdateEnemy(Transform playerObj)
        {

        }
    }

}