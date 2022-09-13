using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform balle;

    float timeSinceLastShot;

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
    }

    private bool CanShoot() => timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void Shoot()
    {
        if (CanShoot()){
            if (Physics.Raycast(balle.position, balle.forward, out RaycastHit hitInfo, gunData.maxDistance)){
                IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                damageable.Damage(gunData.damage);
            }
            timeSinceLastShot = 0;
            OnGunShot();
        }
    }

    private void Update(){
        timeSinceLastShot += Time.deltaTime;
    }

    private void OnGunShot(){
        Debug.Log("KWA FEUR");
    }

}
