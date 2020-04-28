using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* every _item_ created will have these specifications
* armour, weapons, misc items.
*/
public class itemBase : ScriptableObject
{
    //every item will have an:

    //todo add model, 2d sprite (for inv) 
        [SerializeField]
        [Tooltip("Name.")]
        private string _name;
        [SerializeField]
        [Tooltip("Description.")]
        private string _desc;
        [SerializeField]
        [Tooltip("Size of the item within the game.")]
        private int _itemSize;
        [SerializeField]
        [Tooltip("Item weight for carrying")]
        private int _itemWeight;
        

        //model
        //in inventory sprite
        //???????

        public string Name => _name;
        public string Desc => _desc;
        public int ItemSize => _itemSize;    
        public int ItemWeight => _itemWeight;    
}
