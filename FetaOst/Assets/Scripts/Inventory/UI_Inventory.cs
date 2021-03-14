using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;

    private Transform itemSlotContainer;
    private Transform itemTemplate;

    private void Awake()
    {
        
    }

    public void SetInventory(Inventory inventory)
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemTemplate = itemSlotContainer.Find("itemTemplate");
        this.inventory = inventory;

        inventory.OnItemListChange += Inventory_OnItemListChange;
        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChange(object sender, System.EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach(Transform child in itemSlotContainer)
        {
            if (child == itemTemplate) continue;
            Destroy(child.gameObject);
        }

       

        int x = 0;
        int y = 0;
        float itemSlotCellSize = 12.4f;
        foreach(Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = item.GetSprite();

            itemSlotRectTransform.GetComponent<Button_UI>().ClickFunc = () =>
            {
                inventory.ChooseItem(item);
            };

            //texten funkar inte
            TextMeshProUGUI uiText = itemSlotRectTransform.Find("text").GetComponent<TextMeshProUGUI>();
            if (item.amount > 1)
            {
                Debug.Log(item.amount);
                uiText.SetText(item.amount.ToString());
            } else
            {
                uiText.SetText("");
            }

            x++;
            if (x > 8)
            {
                x = 0;
                y++; //det finns bara en rad i min inventory men har denna tills vidaer
            }
        }
    }
}
