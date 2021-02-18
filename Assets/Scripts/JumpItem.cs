using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpItem : MonoBehaviour
{
    [SerializeField] float m_JumpMultiplier = 2f;
    [SerializeField] float m_JumpTimer = 4f;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SimpleMovement>())
        {
            StartCoroutine(TempJumpBoost(other.GetComponent<SimpleMovement>()));

            // zet de collider uit
            gameObject.GetComponent<Collider>().enabled = false;

            // zet de renderer uit
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    IEnumerator TempJumpBoost(SimpleMovement movement)
    {
        // zet de Jump hoger
        movement.JumpHeight *= m_JumpMultiplier;
        yield return new WaitForSeconds(m_JumpTimer);
        // zet de Jump weer normaal
        movement.JumpHeight /= m_JumpMultiplier;
        Destroy(gameObject);
    }
}
