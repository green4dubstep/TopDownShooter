using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Entity entity;
    private Transform player;
    private Vector3 direction;

    private Rigidbody2D rb;
    private float distance;
    [SerializeField] private float chaseRange = 5f;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();

        if (player == null)
        {
            Debug.LogError("Player Transform not assigned in EnemyAI script!");
        }
    }

    void Update()
    {
        if (player != null)
        {
            direction = player.position - transform.position;
            
        }
    }

    private void FixedUpdate()
    {
        if (player != null)
        {
                rb.velocity = new Vector2(direction.x, direction.y) * entity.currentSpeed;
        }
    }
}
