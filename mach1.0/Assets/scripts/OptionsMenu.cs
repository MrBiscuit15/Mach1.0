using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public static bool optionsOpen = true;
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void setSettings()
    {
       
    }

   public void backButton()
    {
        optionsOpen = false;
    }
}
