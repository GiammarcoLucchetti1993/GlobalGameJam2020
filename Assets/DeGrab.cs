using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeGrab : MonoBehaviour
{

    public GameObject spriteQ;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Nonno")
        {
            Spawn();
        }



    }

    void OnTriggerExit()
    {

        Disable();


    }



    void Spawn()
    {

        spriteQ.SetActive(true);
    }

    void Disable()
    {
        spriteQ.SetActive(false);
    }
}
