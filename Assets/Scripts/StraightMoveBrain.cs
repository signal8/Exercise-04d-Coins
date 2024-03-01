using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMoveScript : MonoBehaviour
{
	private Player p;

	void Awake()
	{
		p = gameObject.GetComponent<Player>();
	}
	
	void Update()
	{
		p.SetDirectionalInput(new Vector2(-1,0));
	}

	public void hit()
	{
		Destroy(gameObject);
	}
}
