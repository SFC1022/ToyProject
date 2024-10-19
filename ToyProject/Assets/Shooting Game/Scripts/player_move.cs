using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    // 목표
    // 상하좌우 이동
    // 방향 : 상하좌우
    // 속도 : 방향 x 속력

    [Header("속성")]
    public float speed = 5; // 이동 속력

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, vertical, 0);
        dir.Normalize();
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
