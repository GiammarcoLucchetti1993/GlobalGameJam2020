using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    int index;
    public AudioSource audiosrc;
    public GameObject vecchio;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        index = vecchio.GetComponent<Quest>().indiceTag;
        if (index > 0 && !audiosrc.isPlaying)
        {
            audiosrc.Play();
        }
    }
}
