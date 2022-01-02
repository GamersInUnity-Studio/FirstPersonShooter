using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] float damage = 10f;
	[SerializeField] float range = 100f;

	[SerializeField] Camera fpsCam;

	//[SerializeField] ParticleSystem muzzleFlash;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
    }

	void Shoot()
	{
		//muzzleFlash.Play();

		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) 
		{
			Debug.Log(hit.transform.name);

			Target target = hit.transform.GetComponent<Target>();
			if(target != null)
			{
				target.TakeDamage(damage);
			}
		}
	}
}
