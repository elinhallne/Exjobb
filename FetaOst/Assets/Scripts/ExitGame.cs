using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
   public void ExitGameButton()
    {
        switch (this.gameObject.name)
        {
            case "Exit":
                Application.Quit();
                Debug.Log("Exit");
                break;


        }
    }
}
