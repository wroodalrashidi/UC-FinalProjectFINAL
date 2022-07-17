using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public float speed;
    public float stoppingDistance ;
    public float retreatDistance;
    public Transform player;



    void Start()
    {
        player = GameObject .FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } 
        else if (Vector2.Distance(transform.position, player.position) > stoppingDistance && 
        Vector2.Distance(transform.position, player.position) > retreatDistance )
        {
            transform.position = this.transform.position;
        }
        else if ( Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }
}
