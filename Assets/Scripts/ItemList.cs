using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Script to hold all items within the game. 
 * Could be used to pool from to create spawntables.
 *
 */
public class ItemList : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Add all new items to the list.")]
    private List<itemBase> _items;
    public List<itemBase> Items => _items;
}
