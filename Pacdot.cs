using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//觸發檢測器,銷毀豆子
	void OnTriggerEnter2D(Collider2D co)
	{
		if (co.name == "pacman")
			Destroy (gameObject);
	}
}
