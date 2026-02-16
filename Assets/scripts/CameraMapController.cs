using Unity.Cinemachine;
using UnityEngine;

public class CameraMapController : MonoBehaviour
{
    [Header("Cameras")]
    public CinemachineCamera freeCamera;
    public CinemachineCamera[] sectionCameras;

    [Header("UI Panels")]
    public GameObject[] sectionPanels;

    void Start()
    {
        ActivateFreeCamera();
    }

    public void GoToSection(int index)
    {
        // Desactivar cámara libre
        freeCamera.Priority = 0;

        // Activar cámara de sección
        for (int i = 0; i < sectionCameras.Length; i++)
        {
            sectionCameras[i].Priority = (i == index) ? 20 : 0;
        }

        // Activar UI correspondiente
        for (int i = 0; i < sectionPanels.Length; i++)
        {
            sectionPanels[i].SetActive(i == index);
        }
    }

    public void ActivateFreeCamera()
    {
        freeCamera.Priority = 20;

        foreach (var cam in sectionCameras)
        {
            cam.Priority = 0;
        }

        foreach (var panel in sectionPanels)
        {
            panel.SetActive(false);
        }
    }
}
