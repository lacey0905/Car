using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    Rigidbody2D rigidbody;

    public float speed;
    public float turn = 5f;


    void Awake() 
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, Time.deltaTime * input * turn * -1f);
    }

    void FixedUpdate() 
    {
        rigidbody.AddRelativeForce(Vector2.up * speed * Time.fixedDeltaTime);
    }

    
    /*
        - 드리프트
        - 드래프트 시 속도 약간 감소 해야함 -> 정지 하면 안됨
        - 스키드마크X -> 터치 시 바로 드리프트 -> 터치 이펙트
        - 충돌 -> 이펙트
        - 트랙 생성 -> 무한 생성
        - 트랙 조각 자동 조합
        - 스코어
    */


}
