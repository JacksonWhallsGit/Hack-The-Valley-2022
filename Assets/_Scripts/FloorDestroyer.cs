using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour
{
    public GameObject tile;

    void OnTriggerEnter(Collider collision)
    {
        //Instantiate(tile, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z + 120), Quaternion.identity);
        Destroy(collision.gameObject);
    }



}
