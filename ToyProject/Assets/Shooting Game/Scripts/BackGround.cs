using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Material bgMat; // 배경 머터리얼
    public float scrollSpeed = 0.2f; // 배경 이동 속도
    public Vector2 drvector = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        // 이동 = 방향 * 속도 * 시간
        Vector2 direction = drvector;
        bgMat.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}
