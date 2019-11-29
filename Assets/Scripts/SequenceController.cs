using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SequenceController : MonoBehaviour
{
    public Animator animator;
    public string triggerParam;
    public int delaySeconds;

    private void Start()
    {
        Invoke("StartSequence", delaySeconds);
    }

    private void StartSequence()
    {
        animator.SetTrigger(triggerParam);
    }
}
