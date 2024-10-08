using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AttackIdle : MonoBehaviour
{
    private Animator mAnimator;
    private Animator mAnimator2;
    public GameObject target1; 
    public GameObject target2;
    public Transform target11; 
    public Transform target22; 
    public float attackDistanceThreshold = 0.2f;

    void Start()
    {
        mAnimator = target1.GetComponent<Animator>();
        mAnimator2 = target2.GetComponent<Animator>();
    }

    void Update()
    {
        if(mAnimator != null && mAnimator2 != null && target1 != null && target2 != null)
        {
            float distance = Vector3.Distance(target11.position, target22.position);

            if(distance <= attackDistanceThreshold)
            {
                mAnimator.SetTrigger("TrAttack2");
                mAnimator2.SetTrigger("TrAttack3");
            }
            else
            {
                mAnimator.SetTrigger("TrIdle");
                mAnimator2.SetTrigger("TrIdle");
            }
        }
    }
}