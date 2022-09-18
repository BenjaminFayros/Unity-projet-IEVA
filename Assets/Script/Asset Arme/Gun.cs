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
    IDamageable damageable;

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
    }

    private bool CanShoot() => timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void Shoot()
    {
        if (CanShoot()){
            Debug.Log("KWA");
            if (Physics.Raycast(balle.position, balle.up, out RaycastHit hitInfo, gunData.maxDistance)){
                damageable = hitInfo.transform.GetComponent<IDamageable>();
                if(hitInfo.transform.CompareTag("Ennemy")||hitInfo.transform.CompareTag("Decor"))
                {
                    Debug.Log(hitInfo.transform.name);
                    damageable.Damage(gunData.damage);
                } 
            }
            timeSinceLastShot = 0;
            OnGunShot();
        }
    }

    private void Update(){
        timeSinceLastShot += Time.deltaTime;
    }

    private void OnGunShot(){
        Debug.Log("FEUR");
    }

}
