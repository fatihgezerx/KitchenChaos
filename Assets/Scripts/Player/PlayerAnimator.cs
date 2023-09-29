using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Player player;
    private Animator animator;
    private const string IS_WALKING = "IsWalking";
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
