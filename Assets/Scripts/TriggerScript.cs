using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject door;
    public GameObject noticeText;

    //OnTriggerEnter is called when the player touches a trigger object.
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TriggerTag"))
        {
            door.SetActive(false);
            noticeText.SetActive(true);
        }
    }
}
