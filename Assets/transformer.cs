using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformer : MonoBehaviour

{
    [SerializeField] private List<Transform> waypoints;
    [SerializeField] private float movespeed = 5f;
    private int _currentWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        if (waypoints.Count <= 0) return;
        _currentWaypoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }


    private void HandleMovement()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[_currentWaypoint].transform.position, (movespeed * Time.deltaTime));

        

    }

}
