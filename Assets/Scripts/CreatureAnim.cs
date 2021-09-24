using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAnim : MonoBehaviour
{
    private Animator animator;
    private TouchControls touchControls;
    private ModeManager modeManager;
    private float cheerLength;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("Status", 0);
        touchControls = FindObjectOfType<TouchControls>();
        modeManager = FindObjectOfType<ModeManager>();
        cheerLength = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (touchControls.anim == "walk")
        {
            animator.SetInteger("Status", 1);
        }
        else if (modeManager.anim == "cheer")
        {
            animator.SetInteger("Status", 2);
            cheerLength -= Time.deltaTime;
            if (cheerLength <0)
            {
                animator.SetInteger("Status", 0);
                modeManager.anim = "idle";
                cheerLength = 3;
            }
        }
        else
        {
            animator.SetInteger("Status", 0);
        }
    }
}
