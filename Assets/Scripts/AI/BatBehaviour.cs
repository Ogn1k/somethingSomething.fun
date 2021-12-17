using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatBehaviour : Enemy {


    float topY;
    float bottomY;
    float x;

    Controller2D controller;
    Vector3 velocity;
    float gravity;

    public AnimationCurve movementCurve;
    private Rigidbody2D rigidbody2d;
    float speed;
    float timeс;

    Vector3 directiion;

    protected override void Start()
    {
        base.Start();
        x = transform.position.x;
        topY = transform.position.y + 1.5f;
        bottomY = transform.position.y - 1.5f;
        rigidbody2d = GetComponent<Rigidbody2D>();
        controller = GetComponent<Controller2D>();
        gravity = -(2 * 2) / Mathf.Pow(.4f, 2);

    }

    protected override void Update()
    {
        base.Update();

        

        
        
        
    }

    private void FixedUpdate()
    {
        Movement();
        controller.Move(new Vector3(velocity.x * Time.deltaTime, Mathf.Lerp(-.05f, .05f, Mathf.Sin(1.5f * Time.time) / 3.0f + .5f), 0f));
    }

    void Movement()
    {
        timeс += Time.deltaTime;
        float t = Mathf.Sin(1.5f * Time.time) / 2.0f + .5f;
        speed = movementCurve.Evaluate(timeс);

        //directiion = new Vector3(player.transform.position.x, 0, 0) - new Vector3(transform.position.x, 0, 0);



        //transform.position = new Vector3(x, Mathf.Lerp(bottomY, topY, t), 0f);
        if (!(player.transform.position.x < transform.position.x - 4 || transform.position.x + 4 < player.transform.position.x))
        {
            if (transform.position.x > player.transform.position.x)
                velocity.x -= 0.005f;
            else
                velocity.x += 0.005f;
        }
        

    }

    protected override void Die()
    {
        base.Die();
    }

}
