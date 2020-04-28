using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : ScriptableObject {
    /* a player data model should have:
        
        * a model for hp
        * a model for it's inventory
        ? a model for it's current held item ?
        
        ? standard things like:
            * a model
            * ???
    */
    
    [SerializeField]
    [Tooltip("Current HP")]
    private playerHp hp;
    
    [SerializeField]
    [Tooltip("Current Inventory.")]
    private itemInventory inventory;

    public charHP HP => hp;
    public itemInventory Inventory => Inventory;

}
