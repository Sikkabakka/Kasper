using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform ShootPoint;
    private Vector2 direction;
    public GameObject Bullet;
    public float BulletSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    direction = mousePos - (Vector2)ShootPoint.position;
    FaceMouse();      
    if (Input.GetButtonDown("Fire1")){
        Shoot();
    }
    }
    void FaceMouse(){
        ShootPoint.transform.right = direction;
    }
    void Shoot(){
        Bullet = Instantiate(Bullet, ShootPoint.position,ShootPoint.rotation);
        Bullet.GetComponent<Rigidbody2D>().AddForce(ShootPoint.transform.right*BulletSpeed);

        
    }
    
}
