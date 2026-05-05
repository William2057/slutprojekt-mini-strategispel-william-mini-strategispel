using UnityEngine;
using System.Collections;

public class RandomBoxSpawner : MonoBehaviour
{
    [Header("Prefab to spawn")]
    public GameObject prefab;

    [Header("Spawn Areas (BoxCollider2D)")]
    public BoxCollider2D[] spawnAreas;

    private void Start()
    {
        StartCoroutine(SpawnAfterDelay());
    }

    IEnumerator SpawnAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        SpawnOnce();
    }

    void SpawnOnce()
    {
        if (spawnAreas == null || spawnAreas.Length == 0)
        {
            Debug.LogError("No spawn areas assigned!");
            return;
        }

        BoxCollider2D area = spawnAreas[Random.Range(0, spawnAreas.Length)];
        Vector2 spawnPos = GetRandomPointInBounds(area.bounds);

        Instantiate(prefab, spawnPos, Quaternion.identity);
    }

    Vector2 GetRandomPointInBounds(Bounds bounds)
    {
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        return new Vector2(x, y);
    }
}