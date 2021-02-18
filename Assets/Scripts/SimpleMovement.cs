using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] public float JumpHeight = 8f;
    [SerializeField] float m_Speed = 3f;

    Animator animator;

    private CapsuleCollider m_Collider;
    private Rigidbody m_Rbody;

    public bool m_IsGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<CapsuleCollider>();
        m_Rbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
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

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) && m_IsGrounded == true)
        {
            m_Rbody.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.Impulse);
            m_IsGrounded = false;
        }

        if (m_IsGrounded == false)
        {
            animator.SetTrigger("IsJumping");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_IsGrounded = true;
        animator.ResetTrigger("IsJumping");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpeedBoost"))
        {
            TileSpeed.instance.ActivateSpeedBoost();
        }
    }
}
