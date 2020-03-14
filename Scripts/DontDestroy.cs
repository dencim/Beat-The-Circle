using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	void Update () {

		DontDestroyOnLoad(gameObject);
	
	}
}
