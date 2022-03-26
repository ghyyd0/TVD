using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : Character
{
    private void Awake()
    {
        type = CharacterType.vampire;
        hp = 100;
        speed = 5;
        enemies.Add(CharacterType.human);
        
    }
}
