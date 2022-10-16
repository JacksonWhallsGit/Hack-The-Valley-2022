using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject tile;
    public bool isEmpty;

    void FixedUpdate()
    {
        isEmpty = true;
    }

    void OnTriggerStay(Collider collision)
    {
        isEmpty = false;
    }

    void Update()
    {
        if (isEmpty)
        {
            Instantiate(tile, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
        }
    }



}
