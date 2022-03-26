using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Character
{
    private void Awake()
    {
        type = CharacterType.human;
        speed = 5;
        keysType.Add(CharacterType.vampire); 
        keysType.Add(CharacterType.werewolf);
    }
}
