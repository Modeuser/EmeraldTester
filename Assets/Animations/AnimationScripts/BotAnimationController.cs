using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
}
