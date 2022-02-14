using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower; // public���� �����ϸ� unity edit���� ���� ���� ����
    // Start is called before the first frame update
    void Start() // ���۽� �ѹ� �ʱ�ȭ ���� �ڵ�
    {
        rb = GetComponent<Rigidbody2D>();     // Rigidbody2D ������Ʈ�� �����ͼ� rb�� ��ڴ� (�ʱ�ȭ)
    }

    // Update is called once per frame
    void Update() // �� �����Ӹ��� ȣ���.
    {
        if (Input.GetMouseButtonDown(0)) // 0 ? ���콺 ���ʹ�ư
        {

            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,1) => (0,3) ���콺 ���ʹ�ư�� ������ ���� �������� 3��ŭ �����ϵ���
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // �浹�� �߻�������
    {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
