using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    Rigidbody rb;
    public int speed;

    public Transform gun;
    public Transform gun2;
    public GameObject prefab;
    public int bulletType;

    void Start()
    {
        rb= GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        Vector3 directionX = Input.GetAxis("Horizontal")*Vector3.right;
        
        Vector3 totalSpeed = directionX*speed;

        rb.velocity = totalSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            
            
            GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
            bullet.transform.position = gun.position;
            bullet.SetActive(true);
        }
        
        if(Input.GetButtonDown("Jump"))
        {
            
            
            GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
            bullet.transform.position = gun2.position;
            bullet.SetActive(true);
        }
        

    }
}
