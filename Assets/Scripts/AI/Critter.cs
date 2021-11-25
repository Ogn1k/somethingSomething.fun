using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : Enemy
{
    Animator animator;
    

    protected override void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
    }

    protected override void Update()
    {
        base.Update();
        Movement();
    }

    void Movement()
    {
        
        
        if(player.transform.position.x + 10 > transform.position.x && player.transform.position.x - 10 < transform.position.x || player.transform.position.x - 10 < transform.position.x)
        {
            //animation spotted

        }
    }
}