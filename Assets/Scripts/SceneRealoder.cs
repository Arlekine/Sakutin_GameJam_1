using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRealoder : MonoBehaviour
{
    public HealthSystem healthSystem;

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
        SceneManager.LoadScene(0);
    }
}