using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnakMovement : MonoBehaviour
{
    public Animator anim;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveAnak();
    }
    public void moveAnak()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed * Time.deltaTime;
        if (horizontalMove != 0)
        {
            anim.SetBool("walk", true);
        } else
        {
            anim.SetBool("walk", false);
        }
        
    }
}
