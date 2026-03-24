using UnityEngine;

public class UIPanelController : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
