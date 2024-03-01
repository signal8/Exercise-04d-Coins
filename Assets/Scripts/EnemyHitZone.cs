using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitZone : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		gameObject.transform.parent.gameObject.SendMessage("hit");
	}
}
