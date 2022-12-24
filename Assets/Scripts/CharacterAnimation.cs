using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public RuntimeAnimatorController[] runtimeAnimatorControllers;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        int rand = Random.Range(0, runtimeAnimatorControllers.Length);
        anim.runtimeAnimatorController = runtimeAnimatorControllers[rand];
    }
}
