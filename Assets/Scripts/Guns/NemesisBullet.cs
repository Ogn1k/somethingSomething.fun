using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemesisBullet : Projectile
{
    //private float fireRate = .5f;

    //private float nextFire;

    protected override void Awake()
    {
        base.Awake();

    }

    protected override void OnEnable()
    {
        base.OnEnable();
        
    }

    protected override void Update()
    {
        base.Update();
        ObjectPoolManager.instance.SpawnFromPool("particle_nemesisShoot", transform.position, Quaternion.identity);
    }


    protected override void Die(bool surfaceHit)
    {
        base.Die(surfaceHit);
        
    }
}