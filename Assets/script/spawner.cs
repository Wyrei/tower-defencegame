using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject spawnobject;
    public Vector2 spawnpoint;
    public int timetilnextspawn;
    int x = 0;
    public float timer;
    public int enemies;
    public bool enemieskunnenspawnen = true;
    public GameObject panel;
    public GameObject enemy;
    public Transform target;
    public float range;

    void Start()
    {
        panel.SetActive(false);
        timer = 2;
        spawnpoint.x = x;
    }
     void Update()
    {
        timer -= Time.deltaTime;
        spawn();
        Collider2D[] cols = Physics2D.OverlapCircleAll((Vector2)transform.position, range);
        if (cols.Length > 0)
        {
            target = cols[0].gameObject.transform;
        }
        foreach (Collider2D col in cols)
        {
            
        }
    }
    void spawn()
    {
        if (enemieskunnenspawnen == true)
        {
            if (timer <= timetilnextspawn)
            {

                spawnpoint.x = x;
                Instantiate(spawnobject, spawnpoint, Quaternion.identity);
                timer = 0.5f;
                enemies -= 1;
                if (enemies == 0)
                {
                    enemieskunnenspawnen = false;
                    enemy.SetActive(false);
                }
            }
        }
      


    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
