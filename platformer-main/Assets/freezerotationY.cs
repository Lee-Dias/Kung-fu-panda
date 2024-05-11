using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezerotationY : MonoBehaviour
{
    public int targetTime = 3;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        targetTime -= 1;
        if (targetTime <= 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            rb.constraints -= RigidbodyConstraints2D.FreezePositionX;
        }
    }
}
