using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Basket : MonoBehaviour {

    public Text scoreGT;

	// Use this for initialization
	void Start () {
        GameObject scoreGO = GameObject.FindGameObjectWithTag("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mousPos2D = Input.mousePosition;
        mousPos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousPos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
	}

    void OnCollisionEnter( Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if( collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }

        int score = int.Parse(scoreGT.text);
        score += 100;
        scoreGT.text = score.ToString();

        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
            
    }

    
}
