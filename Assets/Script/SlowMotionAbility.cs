using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionAbility : MonoBehaviour
{
    
    [SerializeField] public float CurrentTime ;
    [SerializeField] public float StartingTime ;

    
    public SlowMotionAbility sma;
    public CooldownAbility ca;
    // Start is called before the first frame update
    public void Start()
    {
        ca = GetComponent<CooldownAbility>();
        Time.timeScale = 1;
        CurrentTime = StartingTime;
       

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Time.timeScale = .2f ;
        }
        
        if (Time.timeScale == .2f )
        {
            CurrentTime -= 1 * Time.deltaTime;
        }
        
        if (CurrentTime <= 0)
        {
           
            Time.timeScale = 1f;
            CurrentTime = StartingTime;
            sma.enabled = false;

        }
        
       
       
        
    }
}
