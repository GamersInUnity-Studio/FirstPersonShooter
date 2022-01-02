using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowCoords : MonoBehaviour
{

	[SerializeField] TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        Vector3 coords = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		text.text = "XYZ: " + coords;
    }
}
