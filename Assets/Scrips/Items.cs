using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public ScriptableItem itemInfo;

    private SpriteRenderer spriteRender; 
    // Start is called before the first frame update
    void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Start()
    {
       spriteRender.sprite = itemInfo.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoreManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
