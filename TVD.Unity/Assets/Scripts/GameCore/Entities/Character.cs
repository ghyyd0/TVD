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
    [SerializeField] Transform [] spawnPoints;
    public Vector3 destinationPoint;
    public bool isPlayerLook;

    private void Start()
    {
        _chracter = GetComponent<NavMeshAgent>();
        spawnPoints = GameObject.FindGameObjectWithTag("Respawn").GetComponentsInChildren<Transform>();
    }
    private void Update()
    { 
        if (isPlayer)
            return;
        destinationPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)].position;

        if (isPlayerLook)
        {
            _chracter.SetDestination(transform.position);
        }
        else
        {
            _chracter.SetDestination(destinationPoint);
        }

    }
}
