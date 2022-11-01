using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    private Animator anim;
    private Inventory inventory;

    private void Start()
    {
        GetReferences();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetWeaponAnimation(0, WeaponType.Revolver);
        }
    }

    private void SetWeaponAnimation(int weaponStyle, WeaponType weaponType)
    {
        Weapon weapon = inventory.GetItem(weaponStyle);
        if (weapon != null)
        {
            if (weapon.weaponType == weaponType)
            {
                anim.SetInteger("weaponType", (int)weaponType);
            }
        }
    }

    private void GetReferences()
    {
        anim = GetComponentInChildren<Animator>();
        inventory = GetComponent<Inventory>();
    }
}
