using UnityEngine;
using System.Collections;

public class RotatingKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(40 * Time.deltaTime, 0, 0));
    }
}
