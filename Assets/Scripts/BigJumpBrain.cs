using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigJumpBrain : MonoBehaviour
{
	private Player p;

	void Awake()
	{
		p = gameObject.GetComponent<Player>();
	}
	
	void Update()
	{
		p.SetDirectionalInput(new Vector2(-1,0));
		p.OnJumpInputDown();
	}

	public void hit()
	{
		Destroy(gameObject);
	}
}
