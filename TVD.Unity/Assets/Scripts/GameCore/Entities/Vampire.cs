using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : Character
{
    private void Awake()
    {
        type = CharacterType.vampire;
        speed = 5;
        keysType.Add(CharacterType.human);
        
    }
}
