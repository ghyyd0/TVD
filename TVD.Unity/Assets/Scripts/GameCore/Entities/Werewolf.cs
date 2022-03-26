using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Werewolf : Character
{
    private void Awake()
    {
        type = CharacterType.werewolf;
        hp = 100;
        speed = 5;
        enemies.Add(CharacterType.human);
    }
}
