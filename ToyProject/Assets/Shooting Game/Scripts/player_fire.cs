using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_fire : MonoBehaviour
{
    [Header("¼Ó¼º")]
    public GameObject bulletFactory;
    public Transform bulletPos;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            InstantBullet();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstantBullet();
        }
    }

    void InstantBullet()
    {
        GameObject bullet = Instantiate(bulletFactory);
        bullet.transform.position = bulletPos.position;
    }
}
