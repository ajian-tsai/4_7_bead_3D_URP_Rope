using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class Rope_change_long : MonoBehaviour
{
	[SerializeField] private float speed = 1;
	ObiRopeCursor cursor;
	ObiRope rope;

	void Start()
	{
		cursor = GetComponentInChildren<ObiRopeCursor>();
		rope = cursor.GetComponent<ObiRope>();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Z))
			cursor.ChangeLength(rope.restLength - speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.X))
			cursor.ChangeLength(rope.restLength + speed * Time.deltaTime);
	}
}
