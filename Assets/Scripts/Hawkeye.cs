using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hawkeye : MonoBehaviour
{

	//public float rotationSpeed = 1f;
	//public float blastPower = 5f;

	//public GameObject arrow;
	//public Transform shotPoint;
	

    // Update is called once per frame
    /*void Update()
    {
        //float horizontalRotation = Input.GetAxis("Horizontal");
		//float verticalRotation = Input.GetAxis("Vertical");

		//transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, horizontalRotation * rotationSpeed, verticalRotation * rotationSpeed));

		if(Input.GetMouseButtonDown(0))
		{
			GameObject createArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
			createArrow.GetComponent<Rigidbody>().velocity = shotPoint.transform.up * blastPower;


		}
    }*/
}
