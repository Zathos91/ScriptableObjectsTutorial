using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText, healthText, attackText;
    [SerializeField] private List<Character> characters;

    private int _currentCharacter;
    private GameObject _player;
    private void Start()
    {
        _currentCharacter = 0;
        _player = GameObject.FindWithTag("Player");
    }

    public void OnNextCharacter()
    {
        _currentCharacter++;
        if (_currentCharacter >= characters.Count) _currentCharacter = 0;
        LoadCharacter();
    }

    void LoadCharacter()
    {
        var currentCharacter = characters[_currentCharacter];
        nameText.text = currentCharacter.name;
        healthText.text = currentCharacter.characterLife.ToString();
        attackText.text = currentCharacter.characterDamage.ToString();
        
        _player.GetComponent<PlayerController>().SetNewCharacter(currentCharacter);
    }
}
