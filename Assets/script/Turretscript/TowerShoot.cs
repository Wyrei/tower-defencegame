using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerShoot : MonoBehaviour
{
    public Transform target;

    public float fireRate = 1f;
    public float firecountdown = 0f;
    public float range;

    public GameObject bulletprefab;
    public Transform firepoint;
   
    

    void Target()
    {
        lookat();
        Update();
        shoot();
    }
    void Update()
    {
        
        
        firecountdown -= Time.deltaTime;

        Collider2D[] cols = Physics2D.OverlapCircleAll((Vector2)transform.position, range);
        if(cols.Length > 0)
        {
            target = cols[0].gameObject.transform;
        }   
        foreach (Collider2D col in cols)
        {
            Debug.Log(col.gameObject.name);
            if (col.gameObject.CompareTag("enemy"))
            {
                if (firecountdown <= 0f)
                {
                    shoot();
                    firecountdown = 1f / fireRate;
                }
            }
        }
    }
    void shoot()
    {
            GameObject bulletgo = (GameObject)Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
            bulletshoot bullet = bulletgo.GetComponent<bulletshoot>();
            if (bullet != null)
            {
                bullet.seek(target);  
            }  
    }

    void lookat()
    {
        
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
