using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity, IHittable
{

    protected SpriteRenderer spriteRenderer;
    protected Player player;

    protected virtual void Start()
    {
        player = Player.instance;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    protected virtual void Update()
    {
        LookAtPlayer();
    }

    public void OnHit(Vector3 position, Projectile projectile)
    {
        SubtractHealth(projectile.damage);
    }

    protected virtual void LookAtPlayer()
    {
        spriteRenderer.flipX = (player.transform.position.x > transform.position.x);
    }


    protected override void Die()
    {
        base.Die();
        ObjectPoolManager.instance.SpawnFromPool("particle_die", transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
