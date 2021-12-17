using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batStand : Enemy
{


    float topY;
    float bottomY;
    float x;

    protected override void Start()
    {
        base.Start();
        x = transform.position.x;
        topY = transform.position.y + 1.5f;
        bottomY = transform.position.y - 1.5f;

    }

    protected override void Update()
    {
        base.Update();

        Movement();
    }


    void Movement()
    {
        float t = Mathf.Sin(1.5f * Time.time) / 2.0f + .5f;
        transform.position = new Vector3(x, Mathf.Lerp(bottomY, topY, t), 0f);


    }

    protected override void Die()
    {
        base.Die();
    }

}
