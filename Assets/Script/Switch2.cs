using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    public Weapon weapon;
    public KeyCode nomor1;
    public KeyCode nomor2;

    void Start()
    {
        weapon = GetComponent<Weapon>();
    }
    
    void Update()
    {
        haha();
    }

    public void haha()
    {
        if (Input.GetKeyDown(nomor1))
        {
            weapon.enabled = true;
        }
        if (Input.GetKeyDown(nomor2))
        {
            weapon.enabled = false;
        }
    }
}

