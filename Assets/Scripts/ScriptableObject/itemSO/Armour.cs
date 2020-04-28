using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Item/Armour", order = 2)]
public class Armour : itemBase
{
    [SerializeField]
    [Tooltip("Protection value.")]
    private float _protection;
    public float Protection => _protection;

}
