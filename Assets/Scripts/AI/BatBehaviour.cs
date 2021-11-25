using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatBehaviour : Enemy {


    float topY;
    float bottomY;
    float x;

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

    }

    protected override void Update()
    {
        base.Update();
        Movement();
    }

    private void FixedUpdate()
    {
        
    }

    void Movement()
    {
        timeс += Time.deltaTime;
        speed = movementCurve.Evaluate(timeс);

        directiion = player.transform.position - transform.position;

        float t = Mathf.Sin(1.5f * Time.time)/2.0f + .5f;

        rigidbody2d.velocity = new Vector2() ;

         //rigidbody2d.velocity = Vector3.MoveTowards(
         //    transform.position - new Vector3(0, transform.position.y, transform.position.z),
         //    player.transform.position - new Vector3(0, player.transform.position.y, player.transform.position.z),
         //    speed * Time.deltaTime);

        //transform.position = new Vector3(x, Mathf.Lerp(bottomY, topY, t), 0f);

    }

    protected override void Die()
    {
        base.Die();
    }

}
