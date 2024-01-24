using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public GameObject gameOverScreen;
    public float jumpForce;
    
    private void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Wall")) return;
        
        gameOverScreen.SetActive(true);
        enabled = false;
    }
}
