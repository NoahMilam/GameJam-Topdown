using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerWeapon : WeaponBase
{

    public Transform Gun;
    public Transform GunEndPoint;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = Gun.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AimWeapon();
        FireWepon();
    }
    
    private void AimWeapon() 
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookAt = (mousePosition - Gun.position).normalized;
        float angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 90;
        Gun.eulerAngles = new Vector3(0, 0, angle);
    }

    private void FireWepon() {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          
            OnShotFired(new OnShootEventArgs
            {
                GunEndPostion = this.GunEndPoint,
                ShootDirection = mousePosition
            });
        }
    }

}
