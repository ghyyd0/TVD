using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterType
{
    human,
    vampire,
    werewolf
}
public class Character : MonoBehaviour
{
    public CharacterType type;
    public float hp;
    public float speed;
    public List<CharacterType> keysType = new List<CharacterType>(); 

}
