using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) // 충돌이 발생했을때
    {
        GetComponent<AudioSource>().Play();
    }
}
