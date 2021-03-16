using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenyButtons : MonoBehaviour
{
    public void buttonPress()
    {
        switch (this.gameObject.name)
        {
            case "StartButton":
                SceneManager.LoadScene("MainLevel");
                break;
            case "HowToButton":
                break;
            case "OptionButton":
                break;
            

        }
    }
}
