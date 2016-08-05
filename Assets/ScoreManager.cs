using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    private float GPA = 4.3f;
    private int CH = 0;
    static ScoreManager dupCheck;

	// Use this for initialization
	void Start () {
	    
        if(dupCheck != null)
        {
            GameObject.Destroy(gameObject);
        }

        else
        {
            
            {
                GameObject.DontDestroyOnLoad(gameObject);
                dupCheck = this;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float getGPA()
    {
        return GPA;
    }

    public int getCH()
    {
        return CH;
    }

    public void setGPA(float gpa)
    {
        GPA = gpa;
    }

    public void setCH(int ch)
    {
        CH = ch;
    }


}
