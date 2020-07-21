using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public GameObject spriteE;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Vinile" || other.gameObject.tag == "Cappello" || other.gameObject.tag == "Aereo" || other.gameObject.tag == "Palla" || other.gameObject.tag == "Profumo" || other.gameObject.tag == "Controller" || other.gameObject.tag == "Casco")
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

        spriteE.SetActive(true);
    }

    void Disable()
    {
        spriteE.SetActive(false);
    }
}
