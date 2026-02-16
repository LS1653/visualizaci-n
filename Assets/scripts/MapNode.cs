using UnityEngine;
using System.Collections;

public class MapNode : MonoBehaviour
{
    [SerializeField] int sectionIndex;
    [SerializeField] CameraMapController cameraController;

    void OnMouseDown()
    {
        cameraController.GoToSection(sectionIndex);
    }
}
