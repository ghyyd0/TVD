using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] GameObject redPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    RaycastHit objectOnHitLine;
    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out objectOnHitLine))
        {
            Debug.DrawLine(transform.position, objectOnHitLine.point, Color.red); 
             
            if(objectOnHitLine.distance < 10)
            { 
                GameObject enemy = objectOnHitLine.transform.gameObject;
                if(enemy.GetComponent<Werewolf>())
                {
                    if (enemy.GetComponent<Werewolf>().enemies.Contains(CharacterType.human))
                    {
                        redPanel.SetActive(true);
                    }
                } 
                else
                {
                    redPanel.SetActive(false);
                }

            } 
        }
    }
}
