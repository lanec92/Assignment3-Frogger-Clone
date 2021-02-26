using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D rb;

   // public float minSpeed = 8f;
    //public float maxSpeed = 12f;

    public float speed = 5f;

   /* private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }*/

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);


    }
    
}
