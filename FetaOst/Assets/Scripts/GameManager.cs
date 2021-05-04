using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static string currentTool = "none";
    public static bool haveFlower = false;
     public static Flowchart flowchart;
    
    public Character chr_Kawi;
    public Character chr_Unkel;
    public Character chr_Noir;

    [SerializeField]
    private GameObject inGameMeny;

    [SerializeField]
    private PlantControler plantControler;

    

    // Start is called before the first frame update
    void Start()
    {
        //kommer säkert behöva skriva en funktion för hur det funkar
        flowchart = GetComponent<Flowchart>();
        flowchart.SetBooleanVariable("HaveFlower", haveFlower);
        



        chr_Kawi.loveMeter.SetSize(0f);
        chr_Unkel.loveMeter.SetSize(0f);

       

    }
    

    // Update is called once per frame
    void Update()
    {
        chr_Kawi.loveMeterValue = flowchart.GetFloatVariable("KwaiLoveMeter");
        chr_Unkel.loveMeterValue = flowchart.GetFloatVariable("UnkelLoveMeter");
        chr_Noir.loveMeterValue = flowchart.GetFloatVariable("NoirLoveMeter");


        chr_Kawi.UpdateLoveValue();
        chr_Unkel.UpdateLoveValue();
        chr_Noir.UpdateLoveValue();

        UpdateFungusVariabels();
        CheatCodes();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!inGameMeny.activeInHierarchy)
            {
                inGameMeny.SetActive(true);
            }
            else
            {
                inGameMeny.SetActive(false);
            }
        }

    }

    private void UpdateFungusVariabels()
    {
        
       
    }

    private void CheatCodes()
    {
        var input = Input.inputString;

        switch (input)
        {
            case "p":
                Debug.Log("Reset Scene");
                SceneManager.LoadScene(1);
                break;
            case "escape":
                if (!inGameMeny.activeInHierarchy)
                {
                    inGameMeny.SetActive(true);
                }
                else
                {
                    inGameMeny.SetActive(false);
                }
                break;
            case "å":
                Application.Quit();
                break;


        }
    }
}
