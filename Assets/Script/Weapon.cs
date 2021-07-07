using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public KeyCode FireBitch;
    [SerializeField] public AudioClip ShootingSound;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource newAudiosource;

    void Start()
    {
        newAudiosource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        ProcessShoot();
    }

    void ProcessShoot()
    {
        if (Input.GetKeyDown(FireBitch))
        {
            Shoot();
           


        }

        void Shoot()
        {
            newAudiosource.PlayOneShot(ShootingSound, 2f);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
