using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//additional libraries
using TMPro;
using UnityEngine.SceneManagement;


public class GCScript : MonoBehaviour
{
    //Grab the ship object
    public GameObject ship;

    //Grab the invader object
    public GameObject invader;

    public GameObject life;

    public TMP_Text scoreText;
    public int score = 0;

    private int lives = 3;

    public bool isDead = false;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ship, new Vector3(0, -3), Quaternion.identity);

        //draw 10 invaders across
        for (int i = -5; i < 5; i++)
        {
            //draw 3 rows down
            for (int j = 2; j < 5; j++)
            {
                Instantiate(invader, new Vector3(i, j), Quaternion.identity);
            }

        }

        //Draw 3 Lives
        for (int i=0; i < 3; i++)
        {
            Instantiate(life, new Vector3(i + 6, 4), Quaternion.identity);
        }
      

    }

    void Update()
    {
        if (isDead ==true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ship, new Vector3(0, -3), Quaternion.identity);
            isDead = false;
        }

    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    public void killed()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
        isDead = true;
        GameObject[] lifeSprites = GameObject.FindGameObjectsWithTag("Life");
        Destroy(lifeSprites[lives-1]);
        lives -= 1;
    }
   

 
}
