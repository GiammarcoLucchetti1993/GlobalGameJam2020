using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    public float maxJump = 5;
    private Rigidbody rigidbody;
    private bool onGround = false;

    //Audio
    AudioSource _jumperAbility;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        _jumperAbility = GameObject.Find("JumperAbility").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rigidbody.AddForce(Vector3.up * maxJump, ForceMode.Impulse);

            if(_jumperAbility != null)
            {
                _jumperAbility.Play();
            }

            //onGround = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arena")
            onGround = true;
    }


    // void OnCollisionEnter(Collision collision)
    //{
    //    onGround = true;
    //}
}
