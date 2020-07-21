using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public void OnClick()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
