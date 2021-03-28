using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPlatform : MonoBehaviour
{
	Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Droplatform()
	{
		rb2d.isKinematic = false;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player" && GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity.y == 0)
		{
			Invoke("Droplatform", 0.5f);
		}
	}
}
