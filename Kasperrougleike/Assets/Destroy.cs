using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float DestroyTimer;
    void Start()
    {
    StartCoroutine(DestroyObject(2));   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator DestroyObject(float waitTime){
            yield return new WaitForSeconds(waitTime);
            Destroy(gameObject);
            
    }
}
