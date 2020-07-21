using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rooms_manager_2 : MonoBehaviour
{
    public GameObject room_zero, room_zero_goal, room_stanza1, room_stanza1_goal, door_1, door_2, door_3, door_4;
    Vector3 initial_position;
    Vector3 initial_position1;
    public bool need_to_drop_room_zero;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 2;
        room_zero.SetActive(false);
        room_stanza1.SetActive(false);
        initial_position = room_zero.transform.localPosition;
        initial_position1 = room_stanza1.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (need_to_drop_room_zero)
        {
            room_zero.SetActive(true);

            room_zero.transform.position = Vector3.Lerp(room_zero.transform.position, room_zero_goal.transform.position, time * Time.deltaTime);

            //if (room_zero.transform.position.x <= room_zero_goal.transform.position.x - 0.000009f)
            //need_to_drop_room_zero = false;
            Invoke("calledAfterOneSecond", 1.0f);
            Invoke("calledAfterTwoSecond", 3.0f);
            Invoke("flying_door_1", 3.5f);
            Invoke("flying_door_2", 3.5f);
            Invoke("flying_door_3", 3.5f);
            Invoke("flying_door_4", 3.5f);

            //need_to_drop_room_zero = false;


        }


    }

    void calledAfterTwoSecond()
    {
        need_to_drop_room_zero = false;
    }

    void calledAfterOneSecond()
    {
        room_stanza1.SetActive(true);

        room_stanza1.transform.position = Vector3.Lerp(room_stanza1.transform.position, room_stanza1_goal.transform.position, time * Time.deltaTime);
    }
    void flying_door_1()
    {

        Vector3 init_pos = door_1.transform.position;
        Vector3 fin_pos = new Vector3(init_pos.x, 15, init_pos.z);
        door_1.transform.position = Vector3.Lerp(init_pos, fin_pos, Time.deltaTime * time);
        if (door_1.transform.position.y >= 13)
            door_1.SetActive(false);
    }
    void flying_door_2()
    {

        Vector3 init_pos = door_2.transform.position;
        Vector3 fin_pos = new Vector3(init_pos.x, 15, init_pos.z);
        door_2.transform.position = Vector3.Lerp(init_pos, fin_pos, Time.deltaTime * time);
        if (door_2.transform.position.y >= 13)
            door_2.SetActive(false);
    }
    void flying_door_3()
    {

        Vector3 init_pos = door_3.transform.position;
        Vector3 fin_pos = new Vector3(init_pos.x, 15, init_pos.z);
        door_3.transform.position = Vector3.Lerp(init_pos, fin_pos, Time.deltaTime * time);
        if (door_3.transform.position.y >= 13)
            door_3.SetActive(false);
    }
    void flying_door_4()
    {

        Vector3 init_pos = door_4.transform.position;
        Vector3 fin_pos = new Vector3(init_pos.x, 15, init_pos.z);
        door_4.transform.position = Vector3.Lerp(init_pos, fin_pos, Time.deltaTime * time);
        if (door_4.transform.position.y >= 13)
            door_4.SetActive(false);
    }
}
