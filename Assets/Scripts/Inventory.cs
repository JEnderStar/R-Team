using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Weapon[] weapons;

    private PlayerHUD hud;
    private void Start()
    {
        GetReferences();
        InitVariables();
    }

    public void AddItem(Weapon newItem)
    {
        int newItemIndex = (int)newItem.weaponStyle;

        if (weapons[(int)newItem.weaponStyle] != null)
        {
            RemoveItem((int)newItem.weaponStyle);
        }
        weapons[(int)newItem.weaponStyle] = newItem;

        //Update.weaponUI
        hud.UpdateWeaponUI(newItem);
    }

    public void RemoveItem(int index)
    {
        weapons[index] = null;
    }

    public Weapon GetItem(int index)
    {
        return weapons[index];
    }
    private void InitVariables()
    {
        weapons = new Weapon[1];
    }

    private void GetReferences()
    {
        hud = GetComponent<PlayerHUD>();
    }
}
