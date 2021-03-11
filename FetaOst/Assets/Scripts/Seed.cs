using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seed : MonoBehaviour
{
    //C1C1C1
    private SpriteRenderer m_SpriteRenderer;
    private Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        //ButtonHandel();
    }

    void TaskOnClick()
    {
        GameManager.currentTool = "seed";
        Debug.Log(GameManager.currentTool);
    }

    /*void ButtonHandel()
    {
        if (GameManager.dailyFlowerGiven == true)
        {
            btn.interactable = false;
            m_SpriteRenderer.color = Color.gray;
        }
        else
        {
            btn.interactable = true;
            m_SpriteRenderer.color = Color.white;
        }
    } */
}
