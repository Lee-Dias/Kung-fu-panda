using System.Collections;
using System.Collections.Generic;
using OkapiKit;
using UnityEngine;

public class EnemtBulletMovement : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    [SerializeField]
    private float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
