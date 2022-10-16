using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public List<GameObject> tiles;
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
            Instantiate(tiles[Random.Range(0,tiles.Count)], new Vector3(0, -0.25f, transform.position.z), Quaternion.identity);
            isEmpty = false;
        }
    }



}
