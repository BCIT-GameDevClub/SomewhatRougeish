using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health = 10;

	public void Damage(int amt)
    {
        health -= amt;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    public virtual void Die()
    {
        gameObject.SetActive(false);
    }
}
