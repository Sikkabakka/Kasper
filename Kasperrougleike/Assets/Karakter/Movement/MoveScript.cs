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
       if (moveX == 0 && moveY == 0){
        print("stopped");
       }
       else{

        move = new Vector2(moveX, moveY);
       }
        
    }
    void Move()
    {
        rb.velocity = new Vector2(move.x , move.y).normalized * movementspeed ;
    }
}