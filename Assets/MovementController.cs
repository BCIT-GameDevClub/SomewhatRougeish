using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed = 5.0f;
    public WeaponBase weaponPrefab;

    private Rigidbody2D rb;
    private WeaponBase weapon;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (weaponPrefab != null)
        {
            var wep = Instantiate<WeaponBase>(weaponPrefab, transform.position, transform.rotation);
            wep.transform.SetParent(transform); // keep scale 
            weapon = wep;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            if (weapon != null)
                weapon.Attack();
    }

    private void FixedUpdate()
    {
        float xVel = Input.GetAxisRaw("Horizontal") * speed;
        float yVel = Input.GetAxisRaw("Vertical") * speed;

        rb.velocity = new Vector2(xVel, yVel);  // non-normalized! diagonal movement will be faster than speed.
    }

}