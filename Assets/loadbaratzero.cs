using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadbaratzero : MonoBehaviour
{
    public Scrollbar slider;
    public GameObject handler;

    // Start is called before the first frame update
    void Start()
    {
 
   }

    // Update is called once per frame
    void Update()
    {
        if (slider.size == 0)
        {
            handler.SetActive(false);
        }
        if (slider.size > 0)
            handler.SetActive(true);
    }
}
