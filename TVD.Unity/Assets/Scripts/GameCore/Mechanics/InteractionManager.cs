using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
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

        }
    }
}
