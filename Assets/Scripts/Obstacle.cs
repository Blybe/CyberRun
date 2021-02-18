using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<SimpleMovement>())
        {
            // zorgt er voor dat je damage neemt na dat je een obstacle raakt
            SimpleMovement.instance.HealthDown();
        }
    }

}
