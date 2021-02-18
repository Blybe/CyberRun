using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public static SimpleMovement instance;

    [SerializeField] public float JumpHeight = 8f;
    [SerializeField] float m_Speed = 3f;

    Animator animator;

    private CapsuleCollider m_Collider;
    private Rigidbody m_Rbody;

    public bool m_IsGrounded = true;

    public int Hitpoints;
    public int MaxHitpoints = 3;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<CapsuleCollider>();
        m_Rbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        Hitpoints = MaxHitpoints;
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
    // Dit Zorgt ervoor dat hij de SpeedBoost Item kan zien en dan dus het hele process van een speedboost kan activeren
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpeedBoost"))
        {
            TileSpeed.instance.ActivateSpeedBoost();
        }
    }

    private void ModifyHealth(int _hp)
    {
        // simpele health functie
        Hitpoints += _hp;

        if (Hitpoints <= 0)
        {
            InterfaceManager.instance.DeathScreen();
        }
    }

    public void HealthDown()
    {
        // zorgt er voor dat de health naar beneden kan worden gehaald
        ModifyHealth(-1);
    }
}
