using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D playerBody;
    public float influenceRange;
    public float intensity;
    public float distance;
    private Vector2 pullForce;

    void Start()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
        print("body is in");
    }
    void Awake()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
        print("body is in");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);
        if (distance <= influenceRange)
        {
            pullForce = (transform.position - player.position).normalized / distance * (intensity/2);
            playerBody.AddForce(pullForce, ForceMode2D.Force);
            print("being pulled");
        }
    }
}
