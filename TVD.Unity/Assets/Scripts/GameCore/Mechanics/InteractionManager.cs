using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] GameObject humanPanel;
    [SerializeField] GameObject vampirePanel;
    [SerializeField] GameObject werewolfPanel;
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

            if (objectOnHitLine.distance < 2)
            {
                
                GameObject enemy = objectOnHitLine.transform.gameObject;
                 

                if (enemy.tag == "Vampire")
                {
                    vampirePanel.SetActive(true);
                    enemy.GetComponent<Vampire>().isPlayerLook = true;
                }
                else
                { 
                    vampirePanel.SetActive(false);  
                }

                if (enemy.tag == "Werewolf")
                {
                    werewolfPanel.SetActive(true);
                }
                else
                {
                    werewolfPanel.SetActive(false);
                }
                if (enemy.tag == "Human")
                {
                    humanPanel.SetActive(true);
                }
                else
                {
                    humanPanel.SetActive(false);
                }
            }
             else
            {
                humanPanel.SetActive(false);
                werewolfPanel.SetActive(false);
                vampirePanel.SetActive(false);
            }
        }
    }
}
