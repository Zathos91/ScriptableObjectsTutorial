using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Character currentCharacter;

    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        SetNewCharacter(currentCharacter);
    }


    public void SetNewCharacter(Character newCharacter)
    {
        currentCharacter = newCharacter;
        _animator.runtimeAnimatorController = currentCharacter.animatorOverrideController;
    }
    
    
}
