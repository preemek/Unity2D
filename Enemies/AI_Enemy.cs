//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Numerics;
//using UnityEngine;
//using Vector2 = UnityEngine.Vector2;
//using Pathfinding;

//public class AI_Enemy : MonoBehaviour
//{
//    public Transform target;
//    public float speed;
//    public float nextWaypointDistance = 3f;

//    Path path_;
//    int currentWaypoint = 0;
//    bool reachedEndOfPath = false;

//    Seeker seeker;
//    Rigidbody2D rb;

//    // Start is called before the first frame update
//    void Start()
//    {
//        seeker = GetComponent<Seeker>();
//        rb = GetComponent<Rigidbody2D>();
//        seeker.StartPath(rb.position, target.position, OnPathComplete);
//        InvokeRepeating("UpdatePath", 0f, .5f);
//    }

//    void UpdatePath()
//    {   
//        if(seeker.IsDone())
//        seeker.StartPath(rb.position, target.position, OnPathComplete);
//    }


//    void OnPathComplete(Path p)
//    {
//        if (!p.error)
//        {
//            path_ = p;
//            currentWaypoint = 0;
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (path_ == null)
//            return;

//        if (currentWaypoint >= path_.vectorPath.Count)
//        {
//            reachedEndOfPath = true;
//            return;
//        }
//        else
//        {
//            reachedEndOfPath = false;
//        }

//        Vector2 direction = ((Vector2)path_.vectorPath[currentWaypoint] - rb.position).normalized;
//        Vector2 force = direction * speed * Time.deltaTime;
//        rb.AddForce(force);

//        float distance = Vector2.Distance(rb.position, path_.vectorPath[currentWaypoint]);

//        if (distance < nextWaypointDistance)
//        {
//            currentWaypoint++;
//        }
//    }
//}

