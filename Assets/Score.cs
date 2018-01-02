using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    private Text scoreText,gameover;
    private int score = 0;
    public FruitSound fs;
    public Bombsound bs;
    
    
    

    // Use this for initialization
    void Awake () {
        gameover = GameObject.Find("Game Over").GetComponent<Text>();
        gameover.gameObject.SetActive(false);
        scoreText=GameObject.Find("Text").GetComponent<Text>();
        scoreText.text = "Score:" + "0";
        

    }
    void OnTriggerEnter2D(Collider2D target)
    {
       
        if (target.tag=="Bomb")
        {
            bs.am.Play();
            transform.position = new Vector2(0, 100);
            gameover.gameObject.SetActive(true);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());


        }
        if(target.tag=="Fruit")
        {
            fs.abn.Play();
           
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = "Score:"+score.ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }
}
