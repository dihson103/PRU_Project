using System.Collections;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject[] grounds; // Use an array to store different ground prefabs
    private bool hasGround;

    void Start()
    {
        SpawnGround();
    }

    void Update()
    {
        // No need for ground spawning in Update; handled in OnTriggerEnter2D and OnTriggerExit2D
    }

    private void SpawnGround()
    {
        int random = Random.Range(0, grounds.Length); // Random index within the array length

        GameObject selectedGround = grounds[random];

        float yOffset = 0f;
        if (random == 0)
        {
            yOffset = -4f;
        }
        else if (random == 1)
        {
            yOffset = 0f;
        }
        else if (random == 2)
        {
            yOffset = 1f;
        }

        Instantiate(selectedGround, new Vector3(transform.position.x + 3, yOffset, 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // You might want to add logic here for when the player enters the ground trigger
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Re-spawn ground when the player exits the ground trigger
            SpawnGround();
        }
    }
}
