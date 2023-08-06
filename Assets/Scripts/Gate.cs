using UnityEngine;

public class Gate : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        // ������� ������ GameManager � �����
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ������, � ������� ���������� ������, �������� �����
        if (other.CompareTag("Ball"))
        {
            // ���������� ���
            Destroy(other.gameObject);

            // ����������� �������
            gameManager.IncrementScore();
        }
    }
}
