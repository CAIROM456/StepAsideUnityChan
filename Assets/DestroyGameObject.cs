using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DestroyGameObject : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 tmp1 = GameObject.Find("Main Camera").transform.position;
		if (tmp1.z >= transform.position.z)
		{
			Destroy(gameObject);
		}
	}
}
