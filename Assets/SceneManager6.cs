using UnityEngine;
using System.Collections;

public class SceneManager6 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel("Ending2");
        }
    }


}
