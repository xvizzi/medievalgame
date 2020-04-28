using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Item/Weapon", order = 1)]
public class Weapon : itemBase
{
    [SerializeField]
    [Tooltip("Damage.")]
    private float _dmg;
    public float DMG => _dmg;
}
