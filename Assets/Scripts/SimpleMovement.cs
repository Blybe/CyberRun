using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] public float JumpHeight = 8f;
    [SerializeField] float m_Speed = 3f;

    private CapsuleCollider m_Collider;
    private Rigidbody m_Rbody;

    public bool m_IsGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<CapsuleCollider>();
        m_Rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            m_Rbody.velocity = new Vector3(0, 0, m_Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_Rbody.velocity = new Vector3(0, 0, -m_Speed);
        }

        if (Input.GetKeyDown(KeyCode.W) && m_IsGrounded == true)
        {
            m_Rbody.velocity = new Vector3(0, JumpHeight, 0);
            m_IsGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_IsGrounded = true;
    }
}
