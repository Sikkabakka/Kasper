using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform ShootPoint;
    private Vector2 direction;
    public GameObject Bullet;
    public float BulletSpeed;
    public bool ReadyToShoot;
    public float waitTime;  
    public PlayerStats PS;

    void Start()
    {
     ReadyToShoot = true;   
    }

    // Update is called once per frame
    void Update()
    {
    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    direction = mousePos - (Vector2)ShootPoint.position;
    FaceMouse();      
    if (Input.GetButtonDown("Fire1") && (ReadyToShoot == true)&&(PS.PlayerAmmo > 0)){
        Shooting();
        PS.PlayerAmmo -= 1;
        StartCoroutine(Fire(waitTime));
        
    }
    }
    void FaceMouse(){
        ShootPoint.transform.right = direction;
    }
    void Shooting(){
        GameObject bulletPrefab = Instantiate(Bullet, ShootPoint.position,ShootPoint.rotation);
        bulletPrefab.GetComponent<Rigidbody2D>().AddForce(ShootPoint.transform.right*BulletSpeed);
        bulletPrefab.AddComponent<Destroy>();
        

        
    }
    private IEnumerator Fire(float waitTime){
        
            ReadyToShoot = false;
            yield return new WaitForSeconds(waitTime);
            ReadyToShoot = true;
        
        
    }

    
}
