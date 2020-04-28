using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* universal object for all characters
* to represent their health
*/

public class charHP : ScriptableObject {
    
    [SerializeField]
    [Tooltip("HP of the chararcter.")]
    private float hp;

    public float HP => hp;
}