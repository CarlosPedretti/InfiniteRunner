using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{

    public GameObject[] obstacles;   
    public float spawnTime = 1f;     
    public Transform spawnPoint;     
    public float speedIncrease = 0.1f; 

    private float spawnTimer;       
    private float obstacleSpeed;   

    void Start()
    {

    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnTime)
        { 
            spawnTimer = 0f; 

            int obstacleIndex = Random.Range(0, obstacles.Length);


            GameObject newObstacle = Instantiate(obstacles[obstacleIndex], spawnPoint.position, Quaternion.identity);

        }
    }
}


