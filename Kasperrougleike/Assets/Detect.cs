using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public Transform Camera;
    public Transform CameraPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
       if(other.tag == "Player") {
        Camera.position = CameraPos.position;
       }
    }
}
