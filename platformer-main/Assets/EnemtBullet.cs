using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtBullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;

    private float timer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2){
            timer=0;
            shoot();
        }
        
    }

    void shoot()
    {
        Instantiate(bulletpos, bulletpos.position, Quaternion.identity);
    }
}
