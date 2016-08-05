using UnityEngine;
using System.Collections;

public class EndingStay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.DontDestroyOnLoad(gameObject);
    }
}
