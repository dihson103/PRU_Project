using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles; // Use an array to store different obstacles
    private float obstacleSpawnInterval = 2.5f;

    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    void Update()
    {
        // No need for any code in Update for obstacle spawning
    }

    private void SpawnObstacle()
    {
        int randomIndex = Random.Range(0, obstacles.Length); // Generate random index within the array length

        GameObject selectedObstacle = obstacles[randomIndex];

        Instantiate(selectedObstacle, new Vector3(transform.position.x, 3f, 0), Quaternion.identity);
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(obstacleSpawnInterval);
        }
    }
}
