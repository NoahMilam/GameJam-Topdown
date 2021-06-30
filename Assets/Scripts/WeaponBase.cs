using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WeaponBase : MonoBehaviour
{
    public event EventHandler<OnShootEventArgs> OnShoot;
    public class OnShootEventArgs : EventArgs {
        public Transform GunEndPostion;
        public Vector3 ShootDirection;
    }

    protected void OnShotFired(OnShootEventArgs e) {
        OnShoot?.Invoke(this, e);
    }
}
