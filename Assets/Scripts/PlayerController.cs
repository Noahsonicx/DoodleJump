using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;

    Rigidbody2D rb;

    float floaty = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        floaty = Input.GetAxis("Horizontal") * moveSpeed;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(floaty, rb.velocity.y);
    }
}
