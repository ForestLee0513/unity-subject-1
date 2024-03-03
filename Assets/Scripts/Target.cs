using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int score = 1;

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision);
        // 과녁이 화살과 충돌했을 때 실행.
        if(collision.CompareTag("Arrow"))
        {
            // 점수 증가
            GameManager.IncreaseScore(score);

            // GameManager.IncreaseScore
            // 과녁과 화살 동시에 제거함.
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
