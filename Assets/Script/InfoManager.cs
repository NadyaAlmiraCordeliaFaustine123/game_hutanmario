using UnityEngine;

public class InfoManager : MonoBehaviour
{
    public GameObject infoPanel;

    public void ShowInfo()
    {
        infoPanel.SetActive(true);
    }

    public void HideInfo()
    {
        infoPanel.SetActive(false);
    }
}