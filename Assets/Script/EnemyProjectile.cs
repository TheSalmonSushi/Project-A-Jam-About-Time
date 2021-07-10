using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyProjectile : MonoBehaviour
{
    public float dieTime;
    public int damage;
    public GameObject impactEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownTimer());
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        
        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }

    IEnumerator CountdownTimer()
    {
        yield return new WaitForSeconds(dieTime);
        Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
