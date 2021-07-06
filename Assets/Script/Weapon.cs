using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public KeyCode FireBitch;
    
    public Transform firePoint;
    public GameObject bulletPrefab;
	
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(FireBitch))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
