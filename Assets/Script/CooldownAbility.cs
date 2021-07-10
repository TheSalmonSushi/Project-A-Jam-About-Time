using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownAbility : MonoBehaviour
{
    [SerializeField] public float CooldownTime;
    [SerializeField] public float StartCooldownTime;

    public SlowMotionAbility sma;
    
    // Start is called before the first frame update
    void Start()
    {
        CooldownTime = StartCooldownTime;
        sma = GetComponent<SlowMotionAbility>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!sma.enabled)
        {
            CooldownTime -= 1 * Time.deltaTime;
        }
        
        if (CooldownTime <= 0)
        {
            sma.enabled = true;
            CooldownTime = StartCooldownTime;
        }
        
    }
}
