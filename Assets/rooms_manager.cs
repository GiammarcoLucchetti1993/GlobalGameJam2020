using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rooms_manager : MonoBehaviour
{
    public GameObject room_zero, room_zero_goal, room_stanza1, room_stanza1_goal, room_stanza3, room_stanza3_goal, door;
    Vector3 initial_position;
    Vector3 initial_position1;
    Vector3 initial_position3;
    public bool need_to_drop_room_zero;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 2;
        room_zero.SetActive(false);
        room_stanza1.SetActive(false);
        room_stanza3.SetActive(false);
        initial_position = room_zero.transform.localPosition;
        initial_position1 = room_stanza1.transform.localPosition;
        initial_position3 = room_stanza3.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (need_to_drop_room_zero)
        {
            room_zero.SetActive(true);

            room_zero.transform.position = Vector3.Lerp(room_zero.transform.position, room_zero_goal.transform.position, time * Time.deltaTime);

            if (room_zero.transform.position.x >= room_zero_goal.transform.position.x - 0.00001f)
                need_to_drop_room_zero = false;
            Invoke("calledAfterTwoSecond", 2.0f);

            Invoke("calledAfterThreeSecond", 3.0f);
            Invoke("flying_door", 4.0f);


        }


    }

    void calledAfterTwoSecond()
    {
        room_stanza1.SetActive(true);

        room_stanza1.transform.position = Vector3.Lerp(room_stanza1.transform.position, room_stanza1_goal.transform.position, time * Time.deltaTime);
    }
    void flying_door()
    {

        Vector3 init_pos = door.transform.position;
        Vector3 fin_pos = new Vector3(init_pos.x, 15, init_pos.z);
        door.transform.position = Vector3.Lerp(init_pos, fin_pos, Time.deltaTime * time);
        if (door.transform.position.y >= 13)
            door.SetActive(false);
    }

    void calledAfterThreeSecond()
    {
        room_stanza3.SetActive(true);

        room_stanza3.transform.position = Vector3.Lerp(room_stanza3.transform.position, room_stanza3_goal.transform.position, time * Time.deltaTime);
    }


}
