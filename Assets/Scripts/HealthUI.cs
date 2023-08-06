using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image livePrefab;
    public Transform livesParent;
    public Sprite fullLive;
    public Sprite emptyLive;
    public HealthSystem healthSystem;

    private List<Image> _lives = new List<Image>();

    private void Start()
    {
        for (int i = 0; i < healthSystem.maxHealth; i++)
        {
            var newLive = Instantiate(livePrefab, livesParent);
            _lives.Add(newLive);   
        }
    }

    private void OnEnable()
    {
        healthSystem.Damaged += UpdateHealth;
    }

    private void OnDisable()
    {
        healthSystem.Damaged -= UpdateHealth;
    }

    private void UpdateHealth(int currentHealth)
    {
        for (int i = 0; i < _lives.Count; i++)
        {
            if (i < currentHealth)
            {
                _lives[i].sprite = fullLive;
            }
            else
            {
                _lives[i].sprite = emptyLive;
            }
        }
    }
}