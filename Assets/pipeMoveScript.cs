using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public static float moveSpeed = 4f;
    public float deadZone = -10f;
    private static float elapsedTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }

        elapsedTime += Time.deltaTime;

        if (elapsedTime >= 60f)
            {
            moveSpeed += 1f;
            elapsedTime = 0f;
            Debug.Log("Speed increased!)");
            }
    }
}
