using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) // �浹�� �߻�������
    {
        GetComponent<AudioSource>().Play();
    }
}
