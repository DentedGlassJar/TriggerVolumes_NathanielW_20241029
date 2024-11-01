using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject door;
    public GameObject noticeText;
    public GameObject nathaniel;
    public GameObject myText;
    public GameObject idol;
    public GameObject player;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);

    }

    //OnTriggerEnter is called when the player touches a trigger object.
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TriggerTag"))
        {
            door.SetActive(false);
            noticeText.SetActive(true);
        }

        if(other.gameObject.CompareTag("IdolTag"))
        {
            idol.SetActive(false);

            // This changes the position of the player to the dark hallway with the red lights.
            player.SetActive(false);
            transform.position = new Vector3(-54.5f, 2f, -2.8f);
            player.SetActive(true);

            // This changes the camera to be looking at the rest of the dark hallway.
            transform.rotation = Quaternion.Euler(0, 180, 0);

            myText.SetActive(true);
            nathaniel.SetActive(true);
        }

        if(other.gameObject.CompareTag("NathanielTag"))
        {
            Debug.Log("Mesh Collider activated");
            gameOverScreen.SetActive(true);
            myText.SetActive(false);
        }
    }
}
