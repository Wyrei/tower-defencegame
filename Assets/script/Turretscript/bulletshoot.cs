using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletshoot : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    
    void Target()
    {
        HitTarget();
        Update();
    }
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
    void HitTarget()
    {
        Destroy(gameObject);
        Destroy(target.gameObject);
    }
}
