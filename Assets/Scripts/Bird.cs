using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2d;
    private float upForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.gameOver == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb2d.AddForce(new Vector2(0f, upForce));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameControl.instance.GameOver();
    }

}
