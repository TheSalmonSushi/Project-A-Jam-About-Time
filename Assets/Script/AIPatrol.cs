using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{
    public float walkSpeed;
    
    [HideInInspector]
    public bool mustPatrol;

    public Rigidbody2D rigidbodai;
    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        rigidbodai.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rigidbodai.velocity.y);
    }

    void Flip()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
    }
}
