using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoreManager : MonoBehaviour
{
    public static InventoreManager instance;

    public ScriptableItem[] wapon;
    public Text[] waponName;
    public Image[] waponSprites; 
    public inventoriSlot[] waponSlots;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this; 
        }
    }

    public void AddItem(ScriptableItem items)
    {
        for(int i = 0; i < wapon.Length; i++)
        {
            if(wapon[i] == null)
            {
                wapon[i] = items;
                waponName[i].text = items.itemName;
                waponSprites[i].sprite = items.itemSprite;


                weaponSlots[i].slotItem = items; 

                return; 
            }
        }
    }

    
}
