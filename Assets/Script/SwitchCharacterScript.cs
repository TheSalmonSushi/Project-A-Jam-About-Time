using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

	
	public GameObject avatar1, avatar2;
	public KeyCode nomor1;
	public KeyCode nomor2;
    public Player2Controller test;
    //public CharaFollow test2;
    public GameObject cmfollow1, cmfollow2;
	
	void Start() 
	{
        test = GetComponent<Player2Controller>();
	}
    void Update()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(true);
        /*avatar2.transform.position = new Vector3(avatar1.transform.position.x - 1.5f,
                avatar1.transform.position.y-0.5f, avatar1.transform.position.z);*/
        avatar2.transform.rotation = Quaternion.Euler(0, 0, 0);
        haha();
        
    }
    public void haha()
    {
        if (Input.GetKey(nomor1))
        {
            test.enabled = true;
            //test2.enabled = true;
            cmfollow1.SetActive(true);
            cmfollow2.SetActive(false);
        }
        if (Input.GetKey(nomor2))
        {
            test.enabled = false;
            //test2.enabled = false;
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(true);
        }
    }

}
