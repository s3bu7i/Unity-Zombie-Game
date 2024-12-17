using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    // Create a public method which reduces hit points by the amount of damage
    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if(hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if(isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }

    public bool IsDead()
    {
        return isDead;
    }
}
