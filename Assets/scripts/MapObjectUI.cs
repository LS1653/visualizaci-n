using UnityEngine;

public class MapObjectUI : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    void OnMouseDown()
    {
        panel.SetActive(true);
    }
}
