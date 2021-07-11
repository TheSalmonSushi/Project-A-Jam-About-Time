using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionAbility : MonoBehaviour
{
    
    [SerializeField] public float CurrentTime ;
    [SerializeField] public float StartingTime ;

    
    public SlowMotionAbility sma;
    public CooldownAbility ca;
    public SwitchCharacterScript sw;
    public Weapon weapon;
    public GameObject obj;
    [SerializeField] public KeyCode slowTime;
    // Start is called before the first frame update
    public void Start()
    {
        ca = GetComponent<CooldownAbility>();
        sw = GetComponent<SwitchCharacterScript>();
        weapon = GetComponent<Weapon>();
        Time.timeScale = 1;
        CurrentTime = StartingTime;
        obj.GetComponent<Weapon>();
    }
    public void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(slowTime))
        {
            Time.timeScale = .2f ;
            
        }
        
        if (Time.timeScale == .2f )
        {
            CurrentTime -= 1 * Time.deltaTime;
            sw.enabled = false;
            obj.GetComponent<Weapon>().enabled = true;
            
        }
        
        if (CurrentTime <= 0)
        {
           
            Time.timeScale = 1f;
            CurrentTime = StartingTime;
            sma.enabled = false;
            sw.enabled = true;
            obj.GetComponent<Weapon>().enabled = false;
            

        }
        
       
       
        
    }
}
