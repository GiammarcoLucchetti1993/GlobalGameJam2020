using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest : MonoBehaviour
{
    public RectTransform up_left, up_right, bottom_left, bottom_right;

    // Start is called before the first frame update

    public AudioSource complete;
    public AudioSource grammofono_LevelMusic;
    public AudioSource quest;


    public string tagObjNonno;
    public int indiceTag;
    public List<string> tagsObjNonno;
    public GameObject bambino;
    public bool deGrab;
    public GameObject sprite;
    public List<GameObject> sprites;
    public List<GameObject> gameObjActiveted;
    public GameObject spheretrigger, loadingBar;
    public GameObject roomMng;
    public GameObject cameraZoom;
    int contDone = 0;
  
    List<int> objUsciti;



    void Start()
    {
        up_left.gameObject.SetActive(false);
        up_right.gameObject.SetActive(false);
        bottom_left.gameObject.SetActive(false);
        bottom_right.gameObject.SetActive(false);


        Disable();

        sprite = sprites[0];

        spheretrigger.gameObject.GetComponent<Light>().range = 0;
        loadingBar.gameObject.GetComponent<Energia>().loadingbar.size = 0;

        tagsObjNonno = new List<string>();

        tagsObjNonno.Add("Vinile");
        tagsObjNonno.Add("Aereo");
        tagsObjNonno.Add("Palla");
        tagsObjNonno.Add("Cappello");
        //tagsObjNonno.Add("Binocolo");
        //tagsObjNonno.Add("Profumo");
        //tagsObjNonno.Add("Controller");
        //tagsObjNonno.Add("Casco");

        tagObjNonno = "Vinile";
        indiceTag = 0;


        deGrab = true;

        //complete = GetComponent<AudioSource>();

    }
    private void Update()
    {
        if (indiceTag == 1)
        {
            bottom_left.gameObject.SetActive(true);
            return;
        }
        if (indiceTag == 2)
        {
            bottom_right.gameObject.SetActive(true);
            return;
        }
        if (indiceTag == 3)
        {
            up_right.gameObject.SetActive(true);
            return;
        }
        if (indiceTag == 4)
        {
            //maybe need to fix
            up_left.gameObject.SetActive(true);

            SceneManager.LoadScene(3);
            return;

            


        }
    }
    public void Done()
    {


        spheretrigger.gameObject.GetComponent<Light>().range = 0;
        loadingBar.gameObject.GetComponent<Energia>().loadingbar.size = 0;

        if (indiceTag != 0)
        {
            complete.Play();
        }

        if (indiceTag == 0)
        {
            grammofono_LevelMusic.Play();

            roomMng.GetComponent<rooms_manager>().need_to_drop_room_zero = true;
            cameraZoom.GetComponent<lerp_camera>().need_to_zoom = true;



        }

        if (contDone == 1)
        {
            roomMng.GetComponent<rooms_manager_2>().need_to_drop_room_zero = true;
            cameraZoom.GetComponent<lerp_camera>().need_to_zoom = true;
        }



        Debug.Log(tagObjNonno);

        gameObjActiveted[indiceTag].SetActive(false);

        indiceTag++;



        tagObjNonno = tagsObjNonno[indiceTag];
        sprite = sprites[indiceTag];




        bambino.GetComponent<Move>().grab = false;


        Debug.Log(indiceTag);


        contDone++;

    }



    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bambino")
        {


            Debug.Log(bambino.gameObject.gameObject.GetComponent<Move>().Oggetto.gameObject.tag);
            if (bambino.gameObject.gameObject.GetComponent<Move>().Oggetto.gameObject.tag == tagObjNonno)
            {
                Done();


            }
            //else if(bambino.gameObject.gameObject.GetComponent<Move>().Oggetto.gameObject.tag != tagObjNonno)
            //{
            //    bambino.gameObject.gameObject.GetComponent<Move>().Oggetto.gameObject.transform.position = bambino.gameObject.gameObject.GetComponent<Move>().tempPosition;
            //}
            Spawn();
            quest.Play();

        }



    }

    void OnTriggerExit()
    {

        Disable();


    }



    void Spawn()
    {

        sprite.SetActive(true);
    }

    void Disable()
    {
        sprite.SetActive(false);
    }


}