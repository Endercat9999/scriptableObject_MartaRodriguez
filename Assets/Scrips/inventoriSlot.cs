using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoriSlot : MonoBehaviour
{
    public ScriptableItem slotItem; 
    public int slotNumber;

    public GameObject insptionWindow;

    public Image insptionImage;

    public Text  insptionName;

    public Text insptionDescription;

    public Button closeButton;

    public Button deleteButton;

    // Start is called before the first frame update
    void Start()
    {
        Button thisButton = GetComponentInChildren<Button>();
        thisButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null && !insptionWindow.activeInHierarchy)
        {
            deleteButton.onClick.AddListener(RemoveItem);
            closeButton.onClick.AddListener(CloseWindow);

            insptionImage.sprite = slotItem.itemSprite;
            insptionName.text = slotItem.itemName;
            insptionDescription.text = slotItem.itemDescription;

            insptionWindow.SetActive(true);
        }
    }

    void RemoveItem()
    {
        if(InventoreManager.instance.wapon[slotNumber] != null)
        {
            InventoreManager.instance.wapon[slotNumber] = null;
            InventoreManager.instance.waponName[slotNumber].text = "Empty";
            InventoreManager.instance.waponSprites[slotNumber].sprite = null;
        }

        CloseWindow(); 

    }

    void CloseWindow()
    {
        deleteButton.onClick.RemoveListener(RemoveItem);
        insptionWindow.SetActive(false);
    }




}
