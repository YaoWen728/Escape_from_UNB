using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour {

    private int KeySwitch = 0;
    private GameObject gameController;
    public Text CHText;
    public Text ACH;
    public Text GPAText;

    // Use this for initialization
    void Start () {
        CHText.text = "Credit Hour: ";
        GPAText.text = "GPA: ";
        gameController = GameObject.Find("Score"); ;

    }
	
	// Update is called once per frame
	void Update () {

        ScoreManager controllerscript = (ScoreManager)gameController.GetComponent("ScoreManager");
        ACH.text = controllerscript.getCH().ToString();
        GPAText.text = "GPA: " + controllerscript.getGPA();

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Collectibles"))
        {
            int CH;
            ScoreManager controllerscript = (ScoreManager)gameController.GetComponent("ScoreManager");
            CH = controllerscript.getCH() + 3;
            controllerscript.setCH(CH);
            other.gameObject.SetActive(false);

        }

        if (other.gameObject.CompareTag("Key"))
        {
            KeySwitch = 1;
            other.gameObject.SetActive(false);

        }

        if (other.gameObject.CompareTag("Door"))
        {
            if (KeySwitch == 1)
            {
                Application.LoadLevel("Chapter2");
            }
        }
    }
}
