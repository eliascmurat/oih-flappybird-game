using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public int timeLife = 3;
    public float speed;

    private void Start()
    {
        Destroy(gameObject, timeLife);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
