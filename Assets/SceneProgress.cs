using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneProgress : MonoBehaviour
{
    [SerializeField] private FirstPersonController _player;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private AudioSource _loseSound;
    [SerializeField] private AudioSource _winSound;

    public void ReloadScene()
    {
        _player.GetComponent<Collider>().enabled = false;
        _loseSound.Play();
        _losePanel.SetActive(true);
        StartCoroutine(LoadSceneAfterPause(SceneManager.GetActiveScene().buildIndex));
    }

    public void LoadNext()
    {
        _player.GetComponent<Collider>().enabled = false;
        _winSound.Play();
        _winPanel.SetActive(true);

        StartCoroutine(LoadSceneAfterPause(SceneManager.GetActiveScene().buildIndex + 1));
    }

    private IEnumerator LoadSceneAfterPause(int sceneIndex)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneIndex);
    }
}
