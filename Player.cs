using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float speed = 5;

	private float mouseDistance;
	private Rigidbody2D rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float xPos = worldPoint.x;

		mouseDistance = Mathf.Clamp(xPos - transform.position.x, -1, 1);

	}

	private void FixedUpdate()
	{
		rb.velocity = new Vector2(mouseDistance * speed, LevelController.instance.gameSpeed);
	}
}
