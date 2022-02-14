using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower; // public으로 선언하면 unity edit에서 변수 수정 가능
    // Start is called before the first frame update
    void Start() // 시작시 한번 초기화 관련 코드
    {
        rb = GetComponent<Rigidbody2D>();     // Rigidbody2D 컴포넌트를 가져와서 rb에 담겠다 (초기화)
    }

    // Update is called once per frame
    void Update() // 매 프레임마다 호출됨.
    {
        if (Input.GetMouseButtonDown(0)) // 0 ? 마우스 왼쪽버튼
        {

            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,1) => (0,3) 마우스 왼쪽버튼이 눌리면 위쪽 방향으로 3만큼 점프하도록
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // 충돌이 발생했을때
    {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
