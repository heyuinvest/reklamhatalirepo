using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel , ComplateFinishPanel , PausePanel, Settings;

    public static bool isGameOver;

    public GameObject ship1, ship2, ship3, ship4, ship5, ship6, ship7;

    public int selectedGame;

    

    // Start is called before the first frame update
    void Start()
    {
        

        GameOverPanel.SetActive(false);
        ComplateFinishPanel.SetActive(false);
        PausePanel.SetActive(false);

        if (PlayerPrefs.HasKey("select"))
        {
            selectedGame = PlayerPrefs.GetInt("select");
        }
        else
            selectedGame = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(WaveSpawner.isGameFinish == true)
        {
            ComplateFinishPanel.SetActive(true);
        }
        // if(PlayerController.isGameOver == true)
        //{
        //    GameOverPanel.SetActive(true);
        
        //}

        if (isGameOver == true)
        {
            GameOverPanel.SetActive(true);

        }


        if (selectedGame == 1)
        {
            ship1.SetActive(true);

            ship2.SetActive(false);
            ship3.SetActive(false);
            ship4.SetActive(false);
            ship5.SetActive(false);
            ship6.SetActive(false);
            ship7.SetActive(false);
        }
        if (selectedGame == 2)
        {
            ship1.SetActive(false);

            ship2.SetActive(true);
            ship3.SetActive(false);
            ship4.SetActive(false);
            ship5.SetActive(false);
            ship6.SetActive(false);
            ship7.SetActive(false);
        }
        if (selectedGame == 3)
        {
            ship1.SetActive(false);

            ship2.SetActive(false);
            ship3.SetActive(true);
            ship4.SetActive(false);
            ship5.SetActive(false);
            ship6.SetActive(false);
            ship7.SetActive(false);
        }
        if (selectedGame == 4)
        {
            ship1.SetActive(false);

            ship2.SetActive(false);
            ship3.SetActive(false);
            ship4.SetActive(true);
            ship5.SetActive(false);
            ship6.SetActive(false);
            ship7.SetActive(false);
        }
        if (selectedGame == 5)
        {
            ship1.SetActive(false);

            ship2.SetActive(false);
            ship3.SetActive(false);
            ship4.SetActive(false);
            ship5.SetActive(true);
            ship6.SetActive(false);
            ship7.SetActive(false);
        }
        if (selectedGame == 6)
        {
            ship1.SetActive(false);

            ship2.SetActive(false);
            ship3.SetActive(false);
            ship4.SetActive(false);
            ship5.SetActive(false);
            ship6.SetActive(true);
            ship7.SetActive(false);
        }
        if (selectedGame == 7)
        {
            ship1.SetActive(false);

            ship2.SetActive(false);
            ship3.SetActive(false);
            ship4.SetActive(false);
            ship5.SetActive(false);
            ship6.SetActive(false);
            ship7.SetActive(true);
        }
    }
    public void Cont()
    {
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        //PlayerController.isGameOver = false;
        PlayerController.health = 1;
        PlayerController.updateController = 0;

        isGameOver = false;
        PlayerController2.health = 1;
        PlayerController2.updateController = 0;

        PlayerController3.health = 1;
        PlayerController3.updateController = 0;

        PlayerController4.health = 1;
        PlayerController4.updateController = 0;

        PlayerController5.health = 1;
        PlayerController5.updateController = 0;

        PlayerController6.health = 1;
        PlayerController6.updateController = 0;

        PlayerController7.health = 1;
        PlayerController7.updateController = 0;
    }
    public void Pausebutton()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

   
    public void pausecont()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void homebutton()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void SetOpen()
    {
        Settings.SetActive(true);
    }
    public void SetClose()
    {
        Settings.SetActive(false);
    }

    public void RestartButton()
    {

        Application.LoadLevel(Application.loadedLevel);

        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        //PlayerController.isGameOver = false;
        PlayerController.health = 1;
        PlayerController.updateController = 0;

        isGameOver = false;
        PlayerController2.health = 1;
        PlayerController2.updateController = 0;

        PlayerController2.health = 1;
        PlayerController2.updateController = 0;

        PlayerController3.health = 1;
        PlayerController3.updateController = 0;

        PlayerController4.health = 1;
        PlayerController4.updateController = 0;

        PlayerController5.health = 1;
        PlayerController5.updateController = 0;

        PlayerController6.health = 1;
        PlayerController6.updateController = 0;

        PlayerController7.health = 1;
        PlayerController7.updateController = 0;
    }
}
