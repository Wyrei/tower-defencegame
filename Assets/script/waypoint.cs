using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waypoint : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] float maxspeed = 2f;
    int waypointindex = 0;
   
    void Start()
    {
        transform.position = waypoints [waypointindex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
        Move();
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards (transform.position,waypoints[waypointindex].transform.position,maxspeed * Time.deltaTime);
        
        if(transform.position == waypoints[waypointindex].transform.position)
        {
            waypointindex += 1;
        }
        if (waypointindex == waypoints.Length)
        {
            Destroy(gameObject);
            
        }
    }
}
