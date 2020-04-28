using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBase : ScriptableObject
{
    //every item will have an:
        [SerializeField]
        [Tooltip("Name.")]
        private string _name;
        [SerializeField]
        [Tooltip("Description.")]
        private string _desc;

        //model
        //in inventory sprite
        //???????

        public string Name => _name;
        public string Desc => _desc;
    
}
