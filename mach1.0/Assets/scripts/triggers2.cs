using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggers2 : MonoBehaviour
{
    public float triggersComplete;
    public float triggerDead;
    public float messageNumber;
    public float restartDelay = 1f;

    public float allhealth;
    public float enemies = 1f;

    public GameObject message2a;
    public GameObject message2b;

    void Start()
    {
        message2a.SetActive(true);
        allhealth = 50 * enemies;
    }
    void Update()
    {

        if (enemy.hitEnemy >=1)
        {
            message2a.SetActive(false);
            message2b.SetActive(true);
            Invoke("nextlevel", restartDelay);
            enemy.hitEnemy = 0;
            gunController.Ammo = 25;

        }
    }

    void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

    
