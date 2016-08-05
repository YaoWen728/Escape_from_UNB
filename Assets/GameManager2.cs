using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour {

    private int KeySwitch = 0;
    private GameObject gameController;
    public Text CHText;
    public Text ACH;
    public Text GPAText;
    public Text flopped;
    private int flopswitch = 0;
    private float timer = 3;
    private int totalscore = 0;
    private int stopPls = 1;

    // Use this for initialization
    void Start()
    {
        CHText.text = "Credit Hour: ";
        flopped.text = "";
        GPAText.text = "GPA: ";
        gameController = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (stopPls == 1)
        {
            ScoreManager controllerscript = (ScoreManager)gameController.GetComponent("ScoreManager");
            ACH.text = controllerscript.getCH().ToString();
            GPAText.text = "GPA: " + controllerscript.getGPA();
        }
        if (flopswitch == 1)
        {
            flopped.text = "Flopped!";
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                Application.LoadLevel("Stage2");
            }
        }

        if (flopswitch == 2)
        {
            flopped.text = ":)";
            timer -= Time.deltaTime; if (timer <= 0)
            {
                Application.LoadLevel("GameOver");
            }

        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("AIAgent"))
        {
            int CH;
            float GPA;
            ScoreManager controllerscript = (ScoreManager)gameController.GetComponent("ScoreManager");
            GPA = controllerscript.getGPA() - 1.0f;
            CH = controllerscript.getCH();
            CH = CH - totalscore;
            controllerscript.setGPA(GPA);
            controllerscript.setCH(CH);
            other.gameObject.SetActive(false);
            if (GPA > 0)
            {
                flopswitch = 1;
            }

            if (GPA <= 0)
            {
                flopswitch = 2;
                stopPls = 0;
                GameObject.Destroy(gameController);
            }
        }

        if (other.gameObject.CompareTag("Collectibles"))
        {
            if (flopswitch == 0 ) {
                int CH;
                ScoreManager controllerscript = (ScoreManager)gameController.GetComponent("ScoreManager");
                CH = controllerscript.getCH() + 3;
                totalscore = totalscore + 3;
                controllerscript.setCH(CH);
                other.gameObject.SetActive(false);
            }
        }

        if (other.gameObject.CompareTag("Key"))
        {
            if (flopswitch == 0)
            {
                KeySwitch = 1;
                other.gameObject.SetActive(false);
            }
        }

        if (other.gameObject.CompareTag("Door"))
        {
            if (KeySwitch == 1 && flopswitch == 0 )
            {
                Application.LoadLevel("Chapter3");
            }
        }
    }
}
