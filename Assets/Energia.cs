using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Energia : MonoBehaviour
{
    float vita;
    public float MaxEnergy;
    public float timer;
    public Scrollbar loadingbar;
    public GameObject sphereTrigger;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        loadingbar.size += Time.deltaTime * 0.02f;

        if(loadingbar.size == 1)
            SceneManager.LoadScene(4);


    }
}
