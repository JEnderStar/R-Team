using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private ProgressBar healthBar;
    [SerializeField] private WeaponUI WeaponUI;

    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        healthBar.SetValues(currentHealth, maxHealth);
    }

    public void UpdateWeaponUI(Weapon newWeapon)
    {
        WeaponUI.UpdateInfo(newWeapon.icon, newWeapon.magazineSize, newWeapon.magazineCount);
    }
}
