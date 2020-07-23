using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDNA : MonoBehaviour
{
	public int rotSpeed = 2;

	void Update()
	{
		transform.Rotate(rotSpeed, 0, 0, Space.Self);
	}
}
