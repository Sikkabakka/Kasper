using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float movementspeed;
    public Rigidbody2D rb;
    private Vector2 move;


    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

    }
    void FixedUpdate() {
        Move();
    }
    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        move = new Vector2(moveX, moveY);
    }
    void Move()
    {
        rb.velocity = new Vector2(move.x * movementspeed, move.y * movementspeed);
    }
}
