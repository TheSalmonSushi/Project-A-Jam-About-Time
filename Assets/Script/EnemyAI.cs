using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float speeeedd = 200f;
    public float PickNextPointDistance = 3f;
    public Rigidbody2D rigidbodai;
    public Seeker parapencariplayer;
    public Transform TheEnemy;
    public int damage;

    private Path pathtoheaven;
    private int currentwaypoint = 0;
    private bool reachedEndofPath = false;

    void Start()
    {
        rigidbodai = GetComponent<Rigidbody2D>();
        parapencariplayer = GetComponent<Seeker>();
        InvokeRepeating("PathGenerator", 0f, .5f);
    }

    void FixedUpdate()
    {
        PathProcess();
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        
    }

    void PathGenerator()
    {
        if (parapencariplayer.IsDone())
        {
            parapencariplayer.StartPath(rigidbodai.position, target.position, OnPathComplete);
        }
       
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            pathtoheaven = p;
            currentwaypoint = 0;

        }
    }

    void PathProcess()
    {
        if (pathtoheaven == null)
            return;

        if (currentwaypoint >= pathtoheaven.vectorPath.Count)
        {
            reachedEndofPath = true;
            return;
        }
        else
        {
            reachedEndofPath = false;
        }

        Vector2 direction = ((Vector2) pathtoheaven.vectorPath[currentwaypoint] - rigidbodai.position).normalized;
        Vector2 force = direction * speeeedd * Time.deltaTime;

        rigidbodai.AddForce(force);
        
        float distance = Vector2.Distance(rigidbodai.position, pathtoheaven.vectorPath[currentwaypoint]);

        if (distance < PickNextPointDistance)
        {
            currentwaypoint++;
        }

        if (force.x >= 0.01f)
        {
            TheEnemy.localScale = new Vector3(-1f, 1f, 1f);
        } else if (force.x <= 0.01f)
        {
            TheEnemy.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    
}
