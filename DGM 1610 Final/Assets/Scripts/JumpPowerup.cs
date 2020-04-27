using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    public double jumpHeight = 0.2f;
    public GameObject pickupEffect;
    public float multiplyer = 1.4f;
    public float duration = 5f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }

        // Destroy(gameObject);
    }

    IEnumerator Pickup(Collider player)
    {
        // Spawn cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        // Do something to player
        PMovement speed = player.GetComponent<PMovement>();
        speed.speed *= multiplyer;

        GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(duration);

        speed.speed /= multiplyer;
        // Destroy gameobject
        Destroy(gameObject);

    }
}
