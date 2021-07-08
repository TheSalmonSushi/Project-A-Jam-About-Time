using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaFollow : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float stoppingDistance;
    public BoxCollider2D col;

    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if(Vector2.Distance(transform.position, target.position) < 1)
        {
            col.enabled = false;
        } else
        {
            col.enabled = true;
        }
    }
}
