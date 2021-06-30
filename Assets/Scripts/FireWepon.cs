using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FireWepon : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    private void Start()
    {
        GetComponent<PlayerWeapon>().OnShoot += Fire;  
    }

    public void Fire(object sender, WeaponBase.OnShootEventArgs e) {
        Debug.Log("fire bullet");

        Vector2 dir = (e.ShootDirection - e.GunEndPostion.position);//.normalized;
        dir.Normalize();

        GameObject bullet = Instantiate(_bulletPrefab, e.GunEndPostion.position,e.GunEndPostion.rotation,null);
        bullet.GetComponent<Bullet>().Init( dir);
    }
}
