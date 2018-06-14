using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreText;
    private int score = 0;


	// Use this for initialization
	void Start () {
        score = 0;
	}

    private void OnCollisionEnter(Collision collision)
    {
        string Tag = collision.gameObject.tag;

        if(Tag == "LargeStarTag")
        {
            score += 10;
        }else if(Tag == "SmallStarTag")
        {
            score += 5;
        }else if(Tag == "LargeCloudTag")
        {
            score += 15;
        }else if(Tag == "SmallCloudTag")
        {
            score += 10;
        }
        
    }
    // Update is called once per frame
    void Update () {
        this.scoreText.text = score.ToString();
	}
}
