using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{

    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;


    private Rigidbody bulletRigidBody;

    private void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 10f;
        bulletRigidBody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.GetComponent<BulletTarget>() !=null) 
        {
            // Hit Target
            Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
        }
        else 
        {
            // Hit Something Else
            Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        }
                
              
        Destroy(gameObject);
    }



}
