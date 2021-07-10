using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaFollow : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float stoppingDistance;
    

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
    }
}
