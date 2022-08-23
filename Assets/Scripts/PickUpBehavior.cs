using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehavior : MonoBehaviour
{
    public Transform spawnPoint;
    public CharacterController player;

    private void OnTriggerEnter(Collider other)
    {
        // Collect pick ups
        if (other.CompareTag("Pick Up"))
        {
            GameObject.Destroy(other.gameObject);
        }

    }
}
