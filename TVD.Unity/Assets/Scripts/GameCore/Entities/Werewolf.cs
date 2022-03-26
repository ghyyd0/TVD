using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Werewolf : Character
{
    private void Awake()
    {
        type = CharacterType.werewolf;
        speed = 5;
        keysType.Add(CharacterType.human);
    }
}
