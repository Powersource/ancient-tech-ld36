using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{

	GameObject bg;

	void Start ()
	{
		bg = GameObject.Find ("bg");
		bg.transform.position = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (Camera.main.orthographicSize);
		print (Camera.main.aspect);
	}
}
