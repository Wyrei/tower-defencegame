using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletshoot : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public int damage = 50;
    
    public void seek(Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distancethisframe = speed * Time.deltaTime;

        if(dir.magnitude <= distancethisframe)
        {   
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distancethisframe, Space.World);
    }
    
    public void HitTarget()
    {
        gamemanager money = target.GetComponent<gamemanager>();
        enemy daamage = target.GetComponent<enemy>();
        daamage.health -= damage;
        if (daamage.health >= 0)
        {
            Destroy(target.gameObject);
        }
        if (daamage.health >= 0)
        {
            //money.gold += 10;
        }
        Destroy(gameObject);
        
    }
}
