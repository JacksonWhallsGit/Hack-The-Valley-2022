using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour
{
    public GameObject tile;

    void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
    }



}
