using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photo_manager : MonoBehaviour
{
    int counter;
    public GameObject image1, image2, image3, image4, canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            canvas.SetActive(true);
            counter += 1;
        }
        switch(counter)
        {
            case 1:
                image1.SetActive(true);
            break;

            case 2:
                image2.SetActive(true);
            break;

            case 3:
                image3.SetActive(true);
            break;

            case 4:
                image4.SetActive(true);
            break;
        }
    }
}
