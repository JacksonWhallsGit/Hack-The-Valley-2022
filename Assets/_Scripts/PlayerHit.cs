using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Y Bot")
		{
			Debug.Log("hit");
		}
	}
}
