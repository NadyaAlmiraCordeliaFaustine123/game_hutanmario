using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    // Animasi
    public float rotateSpeed = 100f;
    public float floatSpeed = 2f;
    public float floatHeight = 0.2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Coin berputar
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);

        // Coin naik turun
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        transform.position = new Vector3(
            transform.position.x,
            newY,
            transform.position.z
        );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Kena Coin!");

        if (other.CompareTag("player"))
        {
            ScoreManager scoreManager = FindFirstObjectByType<ScoreManager>();

            if (scoreManager != null)
            {
                scoreManager.AddScore(coinValue);
            }

            Destroy(gameObject);
        }
    }
}