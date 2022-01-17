using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateObs : MonoBehaviour
{
    public GameObject rocks;
    private int score = 0;
    public Text ScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1.5f);
        
    }

    void CreateObstacle() {
        Instantiate (rocks);
        score++;
        SaveLoadHighscore.SaveHighscore (score);
        if (score >= 10)
            GUIManager.saveLevel (1);
        if (score >= 20)
            GUIManager.saveLevel (2);
    }
    

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "Score : " + score.ToString();   
        
    }
}
