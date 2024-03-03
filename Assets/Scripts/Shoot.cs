using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform arrowTransform;
    public float shootSpoeed = 50f;

    void LookAt()
    {
        // 마우스 위치 파싱
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // 마우스의 위치에 따라 화살의 방향 지정
        Vector2 direction = new(mousePosition.x - arrowTransform.position.x, mousePosition.y - arrowTransform.position.y);
        arrowTransform.right = direction;
    }

    void Fire()
    {
        // 마우스 좌클릭 시 실행.
        if(Input.GetMouseButtonDown(0))
        {
            // 게임 화면에 arrowPrefab 생성
            GameObject newObject = Instantiate(arrowPrefab, arrowTransform.position, arrowTransform.rotation);
            // 새로운 prefab에 velocity를 제공해서 발사 처리.
            newObject.GetComponent<Rigidbody2D>().velocity = arrowTransform.right * shootSpoeed;
        }
    }

    // 1프레임마다 갱신.
    void Update()
    {
        LookAt();
        Fire();
    }
}
