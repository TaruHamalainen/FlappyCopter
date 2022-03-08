

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    private float height = 1.5f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipe), spawnRate, spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipe));
    }
    private void SpawnPipe()
    {
        GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipe.transform.position += Vector3.up * Random.Range(-height, height);
    }
}
