using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Character
{
    private void Awake()
    {
        type = CharacterType.human;
        hp = 100;
        speed = 5;
        enemies.Add(CharacterType.vampire); 
        enemies.Add(CharacterType.werewolf);
    }
}
