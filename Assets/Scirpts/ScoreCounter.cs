using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        ScoreManager.Instance.currentScore++;
    }
}
