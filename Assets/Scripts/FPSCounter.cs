using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{

	[SerializeField] TextMeshProUGUI text;

    // Start is called before the first frame update
    void Awake()
    {
        InvokeRepeating("GetFPS", 1, 1);
    }

    // Update is called once per frame
    void GetFPS()
    {
        int fps = (int)(1f / Time.unscaledDeltaTime);
		text.text = fps + " FPS";
    }
}
