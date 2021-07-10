using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyInfo enemy = hitInfo.GetComponent<EnemyInfo>();
         if (enemy != null)
         {
             enemy.TakeDamage(damage);
         }

         PatrolingEnemyInfo patrolingEnemy = hitInfo.GetComponent<PatrolingEnemyInfo>();
         if (patrolingEnemy != null)
         {
             patrolingEnemy.TakeDamage(damage);
         }
         
        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
