using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float _shotCooldown = 3f;
    [SerializeField] Transform firePoint;

    [Header("Shooting Sound")]
    [SerializeField] AudioSource fireballAudio;
    [SerializeField] AudioClip fireballClip;



    float _lastShotTime =0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && Time.time - _lastShotTime >= _shotCooldown)
        {
            Shoot();
            _lastShotTime = Time.time;

        }

        
    }

    private void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        fireballAudio.PlayOneShot(fireballClip);
    }
}
