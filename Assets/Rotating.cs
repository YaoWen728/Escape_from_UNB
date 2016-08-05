using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3( 0 , 40 * Time.deltaTime, 0));
    }
}
