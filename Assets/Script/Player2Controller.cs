using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    [SerializeField] private float m_JumpForce;
    public bool m_Grounded;
    [SerializeField] protected KeyCode jump;
    private Rigidbody2D m_Rigidbody2D;
    public GameObject avatar1, avatar2;
    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        avatar2.transform.position = new Vector3(avatar1.transform.position.x - 1.8f,
                avatar1.transform.position.y - 0.9f, avatar1.transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetKey(jump)&& m_Grounded)
        {
            m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce ), ForceMode2D.Impulse);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            m_Grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            m_Grounded = false;
        }
    }
}
