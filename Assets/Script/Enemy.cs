using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public AudioClip ExplodeSound;
    [SerializeField] private float DeathDelay;
    
    public int health = 100;

    public GameObject deathEffect;
    public AudioSource newAudiosource;
    public SpriteRenderer rend;
    public BoxCollider2D coliderboss;

    void Start()
    {
        newAudiosource = GetComponent<AudioSource>();
        rend = GetComponent<SpriteRenderer>(); // gets sprite renderer
        coliderboss = GetComponent<BoxCollider2D>();
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    
    

    void Die ()
    {
        
        ProcessDeathSound();
        ProcessDeathAnimation();
        Invoke("DestroyEnemy" ,DeathDelay);
        
      
    }

    void ProcessDeathAnimation()
    {
        Instantiate(deathEffect, transform.position, quaternion.identity);
    }

    void ProcessDeathSound()
    {
        newAudiosource.PlayOneShot(ExplodeSound, 1f);  // plays sound when collided.
        rend.enabled = false; // sets to false if hit.
        coliderboss.enabled = false; // disable box collider
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
