using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float movementspeed;
    public Rigidbody2D rb;
    private Vector2 move;
    private float movespeed;


    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

    }
    void FixedUpdate() {
        Move();
    }
    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal") * movementspeed;
        float moveY = Input.GetAxisRaw("Vertical") * movementspeed;
        // if ((moveX * moveY) != 0){
        //     movespeed = movementspeed/2;
        // } 
        // else{
        //     movespeed = movementspeed ;
        // }
        move = new Vector2(moveX, moveY);
    }
    void Move()
    {
        rb.velocity = new Vector2(move.x , move.y).normalized * movementspeed ;
    }
}
