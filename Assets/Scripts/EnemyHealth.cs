using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHealth = 100f;
    public GameObject pickupAmmo;
    Animator animator;

    public bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        GetComponent<EnemyAI>().OnDamageTaken();
        enemyHealth -= damage;
        if(enemyHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        animator.SetTrigger("Die");
        Instantiate(pickupAmmo, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}
