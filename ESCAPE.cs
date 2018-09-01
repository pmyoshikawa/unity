using UnityEngine;
using System.Collections;

public class ESCAPE : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
        
	#if UNITY_EDITOR

		UnityEditor.EditorApplication.isPlaying = false;

	#elif UNITY_WEBPLAYER
	
	#else
		Application.Quit();
	#endif
}
        }
    }
