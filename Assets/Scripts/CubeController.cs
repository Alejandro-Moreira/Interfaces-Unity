using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnInterval = 1.5f;
    public float spawnXRange = 6f;

    // Posiciones fijas que pediste
    private float baseX = 830.9084f;
    private float baseY = 540f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCube), 1f, spawnInterval);
    }

    void SpawnCube()
    {
        if (cubePrefab == null)
        {
            Debug.LogError("Prefab del cubo no asignado!");
            return;
        }

        // X aleatorio alrededor del valor base
        float randomX = baseX + Random.Range(-spawnXRange, spawnXRange);

        // Z se mantiene igual que la posición del spawner
        Vector3 spawnPos = new Vector3(randomX, baseY, transform.position.z);

        Instantiate(cubePrefab, spawnPos, Quaternion.identity);
    }
}
