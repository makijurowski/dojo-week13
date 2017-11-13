﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			// Load scene 1 upon player death
			Application.LoadLevel(1);
			return;
		}

		if (other.gameObject.transform.parent)
		{
			Destroy(other.gameObject.transform.parent.gameObject);
		}

		else
		{
			Destroy(other.gameObject);
		}
	}
}
