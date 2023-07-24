using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject[] waypoints;
    public int nextWaypointIndex = 1;

    public GameObject nextWaypoint;

    public float movementSpeed = 1;

    public float minDistance = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;

        transform.LookAt(nextWaypoint.transform.position);

        if(Vector3.Distance(nextWaypoint.transform.position, transform.position) <= minDistance)
        {
            if(nextWaypointIndex < waypoints.Length)
            {
                nextWaypoint = waypoints[nextWaypointIndex];

                nextWaypointIndex++;
            }
            else
            {
                print("Ballon ist durch");
            }
        }
    }
}
