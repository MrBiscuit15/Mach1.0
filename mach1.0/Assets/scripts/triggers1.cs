using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggers1 : MonoBehaviour
{
    public float triggersComplete;
    public float triggerDead;
    public float messageNumber;
    public float restartDelay = 1f;

    public GameObject message1a;
    public GameObject message1b;
    public GameObject message1c;

    public void Start()
    {
        displayMessage();
        messageNumber = messageNumber + 1;
    }

    void OnTriggerEnter()
    {
        triggersComplete = triggersComplete + 1;
        Debug.Log(triggersComplete);

        GameObject[] gos = GameObject.FindGameObjectsWithTag("trig1");
        foreach (GameObject go in gos)
            Destroy(go);


        if (triggersComplete >= 1)
        {
            displayMessage();
            triggersComplete = 1;
            messageNumber = messageNumber + 1;
        }
        if (triggersComplete >= 2)
        {
            messageNumber = messageNumber + 1;
        }
    }

    public void displayMessage()
    {
        if (messageNumber == 0)
        {
            Debug.Log("Move around with w,a,s,d.");
            message1a.SetActive(true);
            
        }
        if (messageNumber == 1)
        {
            Debug.Log("Space to jump. Jump on the box.");
            message1a.SetActive(false);
            message1b.SetActive(true);
        }
        if (messageNumber == 2)
        {
            Debug.Log("Level complete.");
            message1b.SetActive(false);
            message1c.SetActive(true);
            Invoke("nextlevel", restartDelay);

        }
    }

    void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

    
