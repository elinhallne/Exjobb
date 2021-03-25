using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField]
    private Font[] myFonts;
    private Text text;
    private int counter;
 
   

   

    // Start is called before the first frame update
    private void Start()
    {
        text = GetComponent<Text>();
        counter = 0;
        text.font = myFonts[counter];

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began )
        {
            counter += 1;
            if (counter > 2)
                counter = 0;
            text.font = myFonts[counter];
        }

      
    }
}
