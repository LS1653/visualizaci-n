using UnityEngine;

public class UIPanelToggle : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void HidePanel()
    {
        panel.SetActive(false);
    }
}
