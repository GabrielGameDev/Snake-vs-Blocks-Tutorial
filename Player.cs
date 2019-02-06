using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float speed = 5;

	public Text livesText;

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
		rb.velocity = new Vector2(mouseDistance * speed, LevelController.instance.gameSpeed * LevelController.instance.multiplier);
	}

	public void SetText(int amount)
	{
		livesText.text = amount.ToString();
	}

	public void TakeDamage()
	{
		int children = transform.childCount;
		if(children <= 1)
		{

		}
		else
		{
			Destroy(transform.GetChild(children - 1).gameObject);
		}

		SetText(children - 1);
	}

}
