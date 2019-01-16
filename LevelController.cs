using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public static LevelController instance;

	public float gameSpeed = 2;

	public int obstaclesAmount = 6;

	public float damageTime = 0.1f;

	public Color easyColor, mediumColor, hardColor;

	private void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
