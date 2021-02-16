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

            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    IEnumerator TempJumpBoost(SimpleMovement movement)
    {
        movement.JumpHeight *= m_JumpMultiplier;
        yield return new WaitForSeconds(m_JumpTimer);
        movement.JumpHeight /= m_JumpMultiplier;
        Destroy(gameObject);
    }
}
