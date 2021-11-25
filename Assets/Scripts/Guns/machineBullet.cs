using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineBullet : Projectile
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    private Vector3 RandomVec(Vector3 min, Vector3 max)
    {
        Vector3 myVector;
       return myVector = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
    }

    protected override void Update()
    {
        time -= Time.deltaTime;
        transform.position += RandomVec( direction + new Vector3(0, 0.15f, 0), direction - new Vector3(0, 0.15f, 0)) * speed * Time.deltaTime;

        if (time < 0f)
        {
            Die(false);
        }

        CheckForCollisions2D();
    }

    protected override void Die(bool surfaceHit)
    {
        base.Die(surfaceHit);
    }

}


