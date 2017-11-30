using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRangeWeapon : WeaponBase
{
    public int damage = 1;
    private Collider2D[] hitZone;


    void Start ()
    {
        hitZone = GetComponents<Collider2D>();
	}

    public override void Attack()
    {
        SetHitZone(true);
        StartCoroutine(DisableHitZoneAfterDelay(0.1f));
    }

    private void SetHitZone(bool on)
    {
        foreach (Collider2D col in hitZone)
            col.enabled = on;
    }

    private IEnumerator DisableHitZoneAfterDelay(float duration)
    {
        yield return new WaitForSeconds(duration);
        SetHitZone(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        if (health != null)
        {
            health.Damage(damage);
        }
    }
}
