using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggers4 : MonoBehaviour
{
    public float triggersComplete;
    public float triggerDead;
    public float messageNumber;
    public float restartDelay = 1f;

    public float allhealth;
    public float enemies = 1f;

    void Start()
    {
        allhealth = 50 * enemies;
    }
    void Update()
    {
        Debug.Log(allhealth);
        if (enemy.hitEnemy >= 3)
        {
            Debug.Log("Check");
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

    
