using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pause : MonoBehaviour
{
    public GameObject gameObject;
    

    public void OnClick()
    {
        gameObject.SetActive(true);

        Time.timeScale = 0f;


    }

}
