using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void MoveDoor()
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }
}
