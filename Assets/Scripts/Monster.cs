using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D body;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        speed = 5f;
    }
   
    private void FixedUpdate()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }
}
