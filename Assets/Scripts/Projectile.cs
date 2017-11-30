using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public int damage = 1;
    public float speed = 5f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        if (health != null)
        {
            health.Damage(damage);
        }
        Destroy(gameObject);
    }
}
