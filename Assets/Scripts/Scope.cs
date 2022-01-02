using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    [SerializeField] bool isScoped = false; 

	[SerializeField] GameObject scopeOverlay;
	[SerializeField] GameObject weaponCamera;

	[SerializeField] Camera mainCamera;

	[SerializeField] float scopedFOV = 15f;
	private float normalFOV;

	void Update()
	{
		if(Input.GetButtonDown("Fire2"))
		{
			isScoped = !isScoped;

			if(isScoped)
			{
				StartCoroutine(OnScoped());
			}

			else
			{
				OnUnScoped();
			}
		}
	}

	void OnUnScoped()
	{
		scopeOverlay.SetActive(false);
		weaponCamera.SetActive(true);

		mainCamera.fieldOfView = normalFOV;
	}


	IEnumerator OnScoped()
	{
		yield return new WaitForSeconds(.15f);

		scopeOverlay.SetActive(true);
		weaponCamera.SetActive(false);

		normalFOV = mainCamera.fieldOfView;
		mainCamera.fieldOfView = scopedFOV;
	}
}
