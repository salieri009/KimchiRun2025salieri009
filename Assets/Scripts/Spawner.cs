using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]

    public float minSpawnDelay;
    public float maxSpawnDelay;

    [Header("References")]
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

    // Update is called once per frame
    void Spawn()
    {
        GameObject gameObject = gameObjects[Random.Range(0, gameObjects.Length)];
        Instantiate(gameObject, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
