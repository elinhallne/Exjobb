using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEndScene : MonoBehaviour
{
public void EndGame()
    {
        SceneManager.LoadScene("EndLevel");
    }
}
