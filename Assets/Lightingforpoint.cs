using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightingforpoint : MonoBehaviour
{
    public Light lighting;

    float intensity;


    void Start()
    {
        lighting.gameObject.GetComponent<SphereCollider>().radius = lighting.range;
        this.GetComponent<Light>().intensity = intensity;
        intensity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        lighting.gameObject.GetComponent<SphereCollider>().radius = lighting.range;
        this.GetComponent<Light>().intensity = intensity;
    }

    private void OnTriggerEnter(Collider other)
    {
        intensity -= Time.deltaTime * 0.08f;
    }

    private void OnTriggerStay(Collider other)
    {
        intensity -= Time.deltaTime * 0.08f;
        intensity = 0;
    }

    void OnTriggerExit(Collider other)
    {
        intensity = 1;
    }


}
