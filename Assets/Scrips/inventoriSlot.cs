using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoriSlot : MonoBehaviour
{
    public ScriptableItem slotItem; 

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
        if(slotItem ! = null && !insptionWindow.activeInHierarchy)
        {
            insptionImage.sprite = slotItem.itemSprite;
            insptionName.text = slotItem.itemName;
            insptionDescription.text = slotItem.itemDescription;

            insptionWindow.SetActive(true);
        }
    }
}
