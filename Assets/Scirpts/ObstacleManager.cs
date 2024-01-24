using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacleGameObject;
    
    public float cooldownTimerBase;
    public float cooldownTimer;

    private int spawnX = 5;
    private int minHeight = -3;
    private int maxHeight = 3;

    private void Start()
    {
        cooldownTimer = cooldownTimerBase;
    }
    
    private void FixedUpdate()
    {
        Cooldown();
    }

    private void Cooldown()
    {
        if (cooldownTimer > 0){
            cooldownTimer -= Time.deltaTime;
        }
        else
        {
            SpawnObstacle();
            cooldownTimer =  cooldownTimerBase - ScoreManager.Instance.currentScore / 10f;
        }
    }

    private void SpawnObstacle()
    {
        Instantiate(obstacleGameObject, new Vector3(
            spawnX, Random.Range(minHeight, maxHeight), 0), Quaternion.identity
        );
    }
}
