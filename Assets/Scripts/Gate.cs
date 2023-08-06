using UnityEngine;

public class Gate : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        // Находим объект GameManager в сцене
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, с которым столкнулся ворота, является шаром
        if (other.CompareTag("Ball"))
        {
            // Уничтожаем шар
            Destroy(other.gameObject);

            // Увеличиваем счетчик
            gameManager.IncrementScore();
        }
    }
}
