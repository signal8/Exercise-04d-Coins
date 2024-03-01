using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargingBrain : MonoBehaviour
{
	private Player p;
	private bool isCharging = false;
    	void Awake()
    	{
        	p = gameObject.GetComponent<Player>();
    	}

    	void Update()
    	{
		if (isCharging) p.SetDirectionalInput(new Vector2(-1,0));
		else
		{
			RaycastHit2D hit = Physics2D.Raycast(
					transform.position,
					new Vector2(-1,0),
					4, LayerMask.GetMask("Player"));
			if (hit.collider != null) isCharging = true;
		}
    	}

	public void hit()
	{
		Destroy(gameObject);
	}
}
