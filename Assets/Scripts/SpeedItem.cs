using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    [SerializeField] float m_SpeedMulitplier = 2f;
    [SerializeField] float m_SpeedTimer = 4f;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(TempSpeedBoost(other.GetComponent<TileMover>()));

        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
    }

    IEnumerator TempSpeedBoost(TileMover mover)
    {
        Debug.Log("Jo Knakker hij werkt");
        mover.speed *= m_SpeedMulitplier;
        yield return new WaitForSeconds(m_SpeedTimer);
        mover.speed /= m_SpeedMulitplier;
        Destroy(gameObject);
    }
}
