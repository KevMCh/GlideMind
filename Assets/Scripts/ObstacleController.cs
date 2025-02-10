using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            transform.position = new Vector3(10f, Random.Range(-2f, 2f), 0f);
        }
    }
}
