using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// we can increase performance in this code by:
// setting a bool variable to use "input.get" only once in update
// using a "string to hash" function for ID optimization

public class BotAnimationController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isAttacking", false);
        }
        if (Input.GetKey(KeyCode.H))
        {
            animator.SetBool("isHit", true);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            animator.SetBool("isHit", false);
        }
    }
}
