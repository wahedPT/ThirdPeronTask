using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   
    public float Bulletspeed = 10f;
    public Vector3 velocity;
    public float bulletSpeed;

    private void Update()
    {
        transform.Translate(velocity);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletref= BulletPool.instance.Get("Bullet");
            if (bulletref != null)
            {
                bulletref.transform.position = transform.position;
                Rigidbody rb = bulletref.GetComponent<Rigidbody>();
                rb.AddForce(bulletref.transform.forward * bulletSpeed);
                bulletref.SetActive(true);
            }
        }

    }

}
