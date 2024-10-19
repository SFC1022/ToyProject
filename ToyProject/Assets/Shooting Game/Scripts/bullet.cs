using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Header("속성")]
    public float speed = 5;

    // 방향 * speed * time.deltatime

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.up;
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
