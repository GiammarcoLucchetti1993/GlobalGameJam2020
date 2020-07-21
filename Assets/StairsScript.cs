using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsScript : MonoBehaviour
{
    bool up, down;
    float secondPlainY, playerY;
    public GameObject firstPlain,secondPlain;
    
    // Start is called before the first frame update
    void Start()
    {
        up = false;
        down = false;
        secondPlain.SetActive(false);

        secondPlainY = secondPlain.transform.position.y;
        secondPlain.transform.position = new Vector3(secondPlain.transform.position.x, secondPlainY, secondPlain.transform.position.z);

        playerY = transform.position.y;
        transform.position = new Vector3(transform.position.x, playerY, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if(up)
        {
            secondPlainY -= Time.deltaTime * 10f;
            secondPlain.transform.position = new Vector3(secondPlain.transform.position.x, secondPlainY, secondPlain.transform.position.z);

            if(secondPlainY <= firstPlain.transform.position.y + 3)
            {
                up = false;
            }
        }

        if(down)
        {
            playerY -= Time.deltaTime * 10f;
            transform.position = new Vector3(transform.position.x, playerY, transform.position.z);

            
            if (playerY <= firstPlain.transform.position.y + 0.5)
            {
                down = false;
                transform.position = new Vector3(transform.position.x, firstPlain.transform.position.y + 3, transform.position.z);
            }
        }

        Debug.Log(down);
        Debug.Log(playerY);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "scalapersalire")
        {
            up = true;
            secondPlain.SetActive(true); 

            transform.position = new Vector3(transform.position.x, secondPlainY + 2, transform.position.z);
        }

        if (other.tag == "scale")
        {
            down = true;
            secondPlain.SetActive(false);

            Debug.Log("Sono entrato");
        }
           

    }


}
