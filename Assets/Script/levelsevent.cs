using UnityEngine;
using UnityEngine.SceneManagement;

public class levelsevent : MonoBehaviour
{
    public void OpenLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}