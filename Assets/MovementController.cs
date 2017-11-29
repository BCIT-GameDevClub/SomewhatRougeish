using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float xVel = Input.GetAxisRaw("Horizontal") * speed;
        float yVel = Input.GetAxisRaw("Vertical") * speed;

        rb.velocity = new Vector2(xVel, yVel);  // non-normalized! diagonal movement will be faster than speed.
    }

}