using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

	
	public GameObject avatar1, avatar2;
	public KeyCode nomor1;
	public KeyCode nomor2;
    public Player2Controller test;
    public GameObject cmfollow1, cmfollow2;
    public Weapon weapon;
    
	
	void Start() 
	{
        test = GetComponent<Player2Controller>();
        weapon = GetComponent<Weapon>();
	}
    void Update()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(true);
        avatar2.transform.position = new Vector3(avatar1.transform.position.x - 2f,
                avatar1.transform.position.y - 0.9f, avatar1.transform.position.z);
        avatar2.transform.rotation = Quaternion.Euler(0, 0, 0);
        haha();
        
    }
    
    public void haha()
    {
        if (Input.GetKey(nomor1))
        {
            test.enabled = true;
            //weapon.enabled = true;
            cmfollow1.SetActive(true);
            cmfollow2.SetActive(false);
        }
        if (Input.GetKey(nomor2))
        {
            test.enabled = false;
            //weapon.enabled = false;
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(true);
        }
    }
}
