using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}