using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Transform textHolderTransform;
    private Transform textTransform;

    private List<Text> textInJournal;

    private float x;
    private float y;
    private float spaceBetweenText = 30.0f;

    private void Start()
    {
        textHolderTransform = gameObject.transform.Find("textholder");
        textTransform = textHolderTransform.Find("Text");

        textInJournal = new List<Text>();
    }

    //addera text till text holdern; Den ska scalas till rätt storlek osv.
   

    public void AddText(Text text)
    {
        textInJournal.Add(text);
    }
    public void PlacementOfTextInJournal()
    {
        foreach (Text textAdded in textInJournal)
        {
            RectTransform journal = Instantiate(textHolderTransform, textTransform).GetComponent<RectTransform>();
            journal.anchoredPosition = new Vector2(x, y * spaceBetweenText);

            x++;
            if (x > 1)
            {
                x = 0;
                y++;
            }
        }
    }
 //uppdatera en bit text 
}
