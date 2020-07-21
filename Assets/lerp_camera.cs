using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp_camera : MonoBehaviour
{
    public bool need_to_zoom;
    float initial_zoom;
    float final_zoom;
    float time;
    bool need_to_dezoom;
    float delta_Time;
    float final_time;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        need_to_zoom = false;
        time = 1.5f;
        final_zoom = 6.5f;
        initial_zoom = 2;
        delta_Time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //quando viene spawnata una qualsiasi stanza bisogna mettere a true la variabile need_to_zoom
        if (need_to_zoom)
        {
            player.GetComponent<Move>().canMove = false;
            float elapsed = 0;
            if (elapsed <= time)
            {
                elapsed += Time.deltaTime;
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, final_zoom, time * Time.deltaTime);
                if(Camera.main.orthographicSize >= final_zoom - 0.3f)
                {
                    delta_Time += Time.deltaTime;
                    if(delta_Time > final_time + 3)
                    {
                        final_time = 0;
                        delta_Time = 0;
                        need_to_dezoom = true;
                        need_to_zoom = false;
                        
                    }
                }
            }
        }
        if(need_to_dezoom)
        {
            player.GetComponent<Move>().canMove = true;

            float elapsed = 0;
            if (elapsed <= time)
            {
                elapsed += Time.deltaTime;
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize ,initial_zoom, time * Time.deltaTime);
                if(Camera.main.orthographicSize <= initial_zoom + 0.15f)
                {
                    need_to_dezoom = false;
                }
            }
        }
    }
}
