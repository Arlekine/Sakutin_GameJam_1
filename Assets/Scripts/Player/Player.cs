using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _numberOfLives;
    [SerializeField] private Image[] _healthImage;
    [SerializeField] private Sprite _fullHealth;
    [SerializeField] private Sprite _emptyHealth;

    private void Update()
    {
        if (_health > _numberOfLives)
        {
            _health = _numberOfLives;
        }


        for (int i = 0; i < _healthImage.Length; i++)
        {
            if (i < _health)
            {
                _healthImage[i].sprite = _fullHealth;
            }
            else
            {
                _healthImage[i].sprite = _emptyHealth;
            }



            if (i < _numberOfLives)
            {
                _healthImage[i].enabled = true;
            }
            else
            {
                _healthImage[i].enabled = false;
            }    
        }

        if (_health == 0)
        {
            RestartScene();
        }
    }


    public void AddHealth(int count)
    {
        if(count < 0)
        {
            count = 1;
        }

        _health += count;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            damage = 1;
        }

        _health -= damage;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
