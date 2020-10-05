using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CurrentWeapon : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Image _weaponIcon;

    private void OnEnable()
    {
        _player.WeaponChanged += ShowWeapon;
    }
    private void OnDisable()
    {
        _player.WeaponChanged -= ShowWeapon;
    }
    private void ShowWeapon(Weapon weapon)
    {
        _weaponIcon.sprite = weapon.Icon;
    }
}
