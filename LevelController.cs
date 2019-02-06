using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public static LevelController instance;

	public float gameSpeed = 2;

	public int obstaclesAmount = 6;

	public float damageTime = 0.1f;

	public Color easyColor, mediumColor, hardColor;

	public float obstaclesDistance = 13;

	public ObjectPool pickupPool;
	public Vector2 xLimit;

	public float multiplier = 1;
	public float cicleTime = 10;

	private Transform player;

	private void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {

		player = FindObjectOfType<Player>().transform;

		SpawnPickups();

		InvokeRepeating("IncreaseDifficulty", cicleTime, cicleTime);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void IncreaseDifficulty()
	{
		obstaclesAmount += 2;

		multiplier *= 1.1f;
	}

	void SpawnPickups()
	{
		pickupPool.GetObject().transform.position = new Vector2(Random.Range(xLimit.x, xLimit.y), player.position.y + 15);

		Invoke("SpawnPickups", Random.Range(1f, 3f));
	}
}
