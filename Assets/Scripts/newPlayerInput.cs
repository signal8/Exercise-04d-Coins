using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newPlayerInput : MonoBehaviour
{
	public Player p;
	public Controller2D c2d;

    	// Update is called once per frame
    	void Update()
    	{
		Animator anim = GetComponentInChildren<Animator>();
		SpriteRenderer sr = GetComponentInChildren<SpriteRenderer>();

        	Vector2 directionalInput = Vector2.zero;
		directionalInput.x = Input.GetAxis("Horizontal");
		directionalInput.y = Input.GetAxis("Vertical");
		p.SetDirectionalInput(directionalInput);

		if (directionalInput.x == 0)
			anim.SetBool("walking", false);
		else 
		{
			anim.SetBool("walking", true);
			if (directionalInput.x < 0) sr.flipX = true;
			else sr.flipX = false;
		}

		if    (Input.GetKeyDown("space")) p.OnJumpInputDown();
		else if (Input.GetKeyUp("space")) p.OnJumpInputUp();

		if (c2d.collisions.below) anim.SetBool("jumping", false);
		else anim.SetBool("jumping", true);
    	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("EndLevel"))
		{
			int scene = SceneManager.GetActiveScene().buildIndex;
			scene++;
			SceneManager.LoadScene(scene);
		}
		else if (col.CompareTag("Coin"))
		{
			Destroy(col.gameObject);
			CoinHandler.addCoins(1);
			Debug.Log(CoinHandler.getCoins());
		}
	}

	public void Hit()
	{
		Destroy(gameObject);
	}
}
