using UnityEngine;

public class RandomScale : MonoBehaviour
{
    public float interval = 0.2f;
    void Start()
    {
        InvokeRepeating(nameof(ChangeScale), 0f, interval);
    }
    private void ChangeScale()
    {
        float scaleX = Random.Range(2f, 3.5f);
        float scaleY = Random.Range(2f, 3.5f);
        float scaleZ = Random.Range(2f, 3.5f);
        transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
    }
}
