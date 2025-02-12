using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float upForce = 5f;
    public float downForce = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, upForce);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -downForce);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ScoreZone"))
        {
            ScoreManager.instance.AddScore(1);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) 
        {
            Debug.Log("¡Game Over!");
            Time.timeScale = 0;
        }
    }
}
