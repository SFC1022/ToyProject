using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("º”º∫")]
    public float speed = 5;
    private Vector3 dir;
    public int HP = 1;

    [Header("¿Ã∆Â∆Æ")]
    public GameObject[] explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10);

        if (randValue < 3)
        {
            GameObject player = GameObject.Find("Player");
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("dz")) return;

        if (other.CompareTag("Bullet"))
        {
            GameObject fire = Instantiate(explosionFactory[1]);
            fire.transform.position = transform.position;       
        }

        if (other.CompareTag("Player"))
        {
            GameObject smoke = Instantiate(explosionFactory[0]);
            smoke.transform.position = transform.position;
        }

        if (HP >= 2)
        {
            Destroy(other.gameObject);
            HP--;
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
