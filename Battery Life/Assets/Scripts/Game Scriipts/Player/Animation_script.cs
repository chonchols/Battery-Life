using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_script : MonoBehaviour
{
    public static Animation_script instance;
    public Animation anim;
    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    public void run_stop()
    {
        animator.SetBool("run", false);
    }
}
