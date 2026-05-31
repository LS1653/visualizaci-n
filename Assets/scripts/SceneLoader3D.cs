using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader3D : MonoBehaviour
{
    [SerializeField] private string sceneName;

    void OnMouseDown()
    {
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
