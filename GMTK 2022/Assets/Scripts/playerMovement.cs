using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    Rigidbody2D rb;

    float horizontal;
    float vertical;



    public float runSpeed = 8f;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
