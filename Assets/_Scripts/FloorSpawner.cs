using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public List<GameObject> tiles;
    public bool isEmpty;

	private void Start()
	{
        //tiles = new List<GameObject>(Resources.LoadAll<GameObject>("Terrain"));
	}

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
            Instantiate(tiles[Random.Range(0,4)], new Vector3(0, -0.25f, transform.position.z), Quaternion.identity);
            isEmpty = false;
        }
    }



}
