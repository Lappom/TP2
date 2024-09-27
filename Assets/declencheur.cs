using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declencheur : MonoBehaviour
{
    public int cubeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            cubeCount++;
            Debug.Log("Cube entré. Nombre de cubes: " + cubeCount);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            cubeCount--;
            Debug.Log("Cube sorti. Nombre de cubes: " + cubeCount);
        }
    }
}
