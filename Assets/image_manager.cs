using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_manager : MonoBehaviour
{
    public GameObject up_left, up_right, bottom_left, bottom_right;
    Vector3 initial_pos, final_pos;
    // Start is called before the first frame update
    void Start()
    {
        up_left.SetActive(false);
        up_right.SetActive(false);
        bottom_left.SetActive(false);
        bottom_right.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
