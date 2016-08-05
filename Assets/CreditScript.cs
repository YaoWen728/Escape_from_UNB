using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditScript : MonoBehaviour {
    public Text T1;

    private GameObject gameController;


    // Use this for initialization
    void Start () {
        gameController = GameObject.Find("Score"); ;
    }
	
	// Update is called once per frame
	void Update () {
        ScoreManager controllerscript = (ScoreManager)gameController.GetComponent("ScoreManager");
        T1.text = "You completed: " + controllerscript.getCH().ToString() + " Credit hour with a " + controllerscript.getGPA().ToString() + " GPA!";

    }
}
