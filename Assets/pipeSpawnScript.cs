using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public static float spawnRate = 2f;
    private float timer;
    public float heightOffset = 1;
    private static float elapsedTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

        elapsedTime += Time.deltaTime;

        if (elapsedTime >= 60f && spawnRate >= 1)
            {
            spawnRate -= 0.05f;
            elapsedTime = 0f;
            Debug.Log("Spawns increased!)");
            }
        }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }

}
