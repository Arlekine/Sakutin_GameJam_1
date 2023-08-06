using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRealoder : MonoBehaviour
{
    public HealthSystem healthSystem;
    public SceneProgress sceneProgress;

    private void OnEnable()
    {
        healthSystem.Dead += ReloadScene;
    }

    private void OnDisable()
    {
        healthSystem.Dead -= ReloadScene;
    }

    private void ReloadScene()
    {
        sceneProgress.ReloadScene();
    }
}