using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indy : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{

		if (collision.gameObject.name == "PlayerObj")
		{

			Destroy (gameObject);



		}

	}

}