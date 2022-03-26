using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public enum CharacterType
{
    human,
    vampire,
    werewolf
}
public class Character : MonoBehaviour
{
    [SerializeField] NavMeshAgent _chracter;
    public CharacterType type;
    public float hp = 100;
    public float speed;
    public List<CharacterType> enemies = new List<CharacterType>();
    public bool isPlayer = false;

    private void Start()
    {
        _chracter = gameObject.AddComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (isPlayer)
            return;

        Vector3 randomPosition = new Vector3(Random.Range(0, 100), 0, Random.Range(0, 100));
        _chracter.SetDestination(randomPosition);
    }
}
