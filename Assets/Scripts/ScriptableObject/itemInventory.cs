using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInventory : ScriptableObject {

    [SerializeField]
    [Tooltip("Size of the player's inventory.")]
    private int _invSize = 11;
    [SerializeField]
    [Tooltip("the items within the inventory.")]
    private List<itemBase> _invetoryItems;

    public int InvSize => _invSize;
    public List<itemBase> InventoryItems => _invetoryItems;


    /* 
    ! for view model, creating grids for inv.
    void createPlayerGrid() {
        for (int i = 0; i < (InvSize / 2); i++)
        {
            //create x roww
            for (int j = 0; j < (InvSize / 2); j++)
            {
                //create y row
            }
            
        }
        var temp = InvSize % 2;
        while(temp != 0)
        {
            //create another square(s)  
            temp--;
        }
    }
    */
}