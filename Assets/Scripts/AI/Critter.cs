using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : Enemy
{
    Animator animator;

    Controller2D controller;

    Vector3 velocity;
    float tx;

    float gravity;
    private float fireRate = 1f;

    private float nextFire;
    protected override void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
        controller = GetComponent<Controller2D>();
        gravity = -(2 * 2) / Mathf.Pow(.4f, 2);
    }

    protected override void Update()
    {
        base.Update();
        
        Animation();
        
    }

    private void FixedUpdate()
    {
        Movement();
        controller.Move(velocity * Time.deltaTime);
    }

    private void Animation()
    {
        if (!(player.transform.position.x < transform.position.x - 6 || transform.position.x + 6 < player.transform.position.x))
        {
            animator.SetFloat("isSpotted", 1);
            if (controller.collisions.below )
            {

                animator.SetFloat("VelocityY", 0);
            }
            else 
            {  
                
                animator.SetFloat("VelocityY", 1);
            }
        }
        else
            animator.SetFloat("isSpotted", 0);

    }

        void Movement()
    {   
         velocity.y += gravity * Time.deltaTime;

        if (!(player.transform.position.x < transform.position.x - 4 || transform.position.x + 4 < player.transform.position.x))
        {
            /*spotted*/
            if (controller.collisions.below && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                velocity.x = 0;
                velocity.y = 10;



            }
            else if (velocity.y > 0)
            {
                if (transform.position.x > player.transform.position.x)
                    velocity.x -= .1f;
                else
                    velocity.x += .1f;
            }
            else if (velocity.y == 0)
                velocity.x = 0;
        }
        else
            velocity.x = 0;
        
    }
}