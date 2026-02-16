using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void OnMouseDown()
    {
        QuitGameMethod();
    }

    void QuitGameMethod()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
