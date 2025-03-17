using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private Rigidbody2D rBody;
    private float speed = 5;
    private float horizontalInput; 

    // Start is called before the first frame update
    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(horizontalInput * speed, rBody.velocity.y); 
    }
}
