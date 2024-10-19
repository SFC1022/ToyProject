using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_manager : MonoBehaviour
{
    [Header("속성")]
    public GameObject EnemyFactory;
    public float creatTime;             // 생성시간
    public float currentTime;   
    // 현재시간

    [Header("랜덤")]
    public float minTime = 0.5f;
    public float maxTime = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        
        if(creatTime <= currentTime)
        {
            InstantEnemy();
            currentTime = 0;
            creatTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }

    void InstantEnemy()
    {
        GameObject enemy = Instantiate(EnemyFactory);
        enemy.transform.localPosition = transform.position;
    }
}
