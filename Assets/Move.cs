using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    public GameObject Busto;
    public GameObject Braccio1;
    public GameObject Braccio2;
    public bool canMove;
    public bool isTriggerOggetto;
    public bool isTriggerNonno;
    public bool grab;
    public GameObject Oggetto;
    public GameObject E_key;
    public GameObject Q_key;
    public Vector3 tempPosition;
    public GameObject Vecchio;
    Collider collider;
    bool isPressed;

    public AudioSource grabAudio;





    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        isTriggerOggetto = false;
        grab = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            transform.position = transform.position;
        }
        if (canMove)
        {

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, speed * Time.deltaTime);
                Busto.transform.localEulerAngles = new Vector3(0f, 0f, 0f);



            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
                Busto.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
                Busto.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

                Busto.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
            }


            if (Input.GetKey(KeyCode.E))
            {

                if (isTriggerOggetto)
                {
                    Oggetto.gameObject.transform.position = new Vector3(transform.position.x, transform.localPosition.y + 1f, transform.position.z);

                    grab = true;
                    E_key.gameObject.SetActive(false);
                }


                grabAudio.Play();


            }
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }








                // if (Input.GetKey(KeyCode.Q))
                //{

                // isPressed = true;


                ////     if (Oggetto.gameObject.tag == Vecchio.gameObject.GetComponent<Quest>().tagObjNonno)
                ////     {
                ////         Vecchio.gameObject.GetComponent<Quest>().Done();
                ////     }

                ////     Q_key.gameObject.SetActive(false);
                ////     grab = false;

                //}



                if (grab )
            {
               
                Oggetto.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
               

                if (Input.GetKey(KeyCode.Space))
                {
                    Oggetto.gameObject.transform.position = tempPosition;
                    grab = false;
                    isTriggerOggetto = false;
                }

            }


        }



    }


    //public void Done()
    //{

    //    //Debug.Log(tagObjNonno);

    //   tagsObjNonno[indiceTag].Remove(indiceTag);

    //    indiceTag = Random.Range(1, tagsObjNonno.Length);
    //    tagObjNonno = tagsObjNonno[indiceTag];

    //}


    void OnTriggerEnter(Collider other)
    {
        collider = other;

        if (other.gameObject.tag == "Vinile" || other.gameObject.tag == "Cappello" || other.gameObject.tag == "Binocolo" || other.gameObject.tag == "Aereo" || other.gameObject.tag == "Palla" || other.gameObject.tag == "Profumo" || other.gameObject.tag == "Controller" || other.gameObject.tag == "Casco")
        {
            isTriggerOggetto = true;
            Oggetto = other.gameObject;
            tempPosition = other.gameObject.transform.position;
        }


        //if (other.gameObject.tag == "Nonno" )
        //{






        // }




    }
}
