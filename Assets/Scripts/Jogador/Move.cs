using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Animator playerAnimator;

    public void PlayAnimation(string animationName)
    {
        playerAnimator.Play(animationName);
    }
    //public Rigidbody2D rb;
   /* public float speed = 4;
    void Start()
    {
        rb = rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void FixedUpdate()
    {
        
    }*/

}
