using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class laser : MonoBehaviour {

	private LineRenderer line;
	// Use this for initialization
	void Start () {
		
		line = GetComponent<LineRenderer>();
		//line = gameObject.GetComponent<LineRenderer>();
		//line.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

		//line.SetPosition (0, transform.position);
		RaycastHit hit;

		line.SetPosition(0, transform.position);

		/*if (Physics.Raycast (transform.position, transform.forward, out hit)) 
		{
			if (hit.collider) 
			{
				line.SetPosition (1, new Vector3(0, 0, hit.distance));
			}
		} 
		else 
		{
			line.SetPosition (1, new Vector3(0, 0, 5000));
		}

		if (Input.GetButtonDown ("Fire1")) {
			StopCoroutine ("FireLaser");
			StartCoroutine ("FireLaser");
		}*/
	}

	/*
	IEnumerator FireLaser()
	{
		//line.enabled = true;

		while (Input.GetButton("Fire1")) {
			Ray ray = new Ray(transform.position, transform.forward);

			//line.SetPosition(1, ray.GetPoint(100));
			//line.SetPosition(0, transform.position);

			yield return null;
		}

		//line.enabled = falsee

	} */

}
