using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public Transform player;  // ������ �� ������
    public Transform targetObject;


    private void OnTriggerEnter(Collider other)
    {
        player.position = targetObject.position;
    }
}
