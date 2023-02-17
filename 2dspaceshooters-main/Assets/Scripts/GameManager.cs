using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject  ShopPanel, Ships, Drones, Upgrades, Asinium;
    public GameObject ShipFocus, DronesFocus, UpgradesFocus, AsiniumFocus;

    public GameObject GameOverPanel , ComplateFinishPanel , PausePanel;

    public static bool isGameOver;

    public GameObject ship1, ship2, ship3, ship4, ship5, ship6, ship7;

    public int selectedGame;

    public int goldMen;
    public TextMeshProUGUI goldMenText;

    public int toolsMen;
    public TextMeshProUGUI toolsMenText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("goldC"))
        {
            goldMen = PlayerPrefs.GetInt("goldC");
        }
        else
            goldMen = 0;

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

        goldMen = PlayerPrefs.GetInt("goldC");
        goldMenText.text = goldMen.ToString();

        toolsMen = PlayerPrefs.GetInt("toolsC");
        toolsMenText.text = toolsMen.ToString();

        if (WaveSpawner.isGameFinish == true)
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

    

    public void Shop()
    {
        ShopPanel.SetActive(true);
    }

    public void Exit()
    {
        
        ShopPanel.SetActive(false);
    }

    public void ShipsPanel()
    {
        Ships.SetActive(true);
        Drones.SetActive(false);
        Upgrades.SetActive(false);
        Asinium.SetActive(false);

        ShipFocus.SetActive(true);
        DronesFocus.SetActive(false);
        UpgradesFocus.SetActive(false);
        AsiniumFocus.SetActive(false);
    }
    public void DronesPanel()
    {
        Ships.SetActive(false);
        Drones.SetActive(true);
        Upgrades.SetActive(false);
        Asinium.SetActive(false);

        ShipFocus.SetActive(false);
        DronesFocus.SetActive(true);
        UpgradesFocus.SetActive(false);
        AsiniumFocus.SetActive(false);
    }
    public void UpgradePanel()
    {
        Ships.SetActive(false);
        Drones.SetActive(false);
        Upgrades.SetActive(true);
        Asinium.SetActive(false);

        ShipFocus.SetActive(false);
        DronesFocus.SetActive(false);
        UpgradesFocus.SetActive(true);
        AsiniumFocus.SetActive(false);
    }
    public void AsinPanel()
    {
        Ships.SetActive(false);
        Drones.SetActive(false);
        Upgrades.SetActive(false);
        Asinium.SetActive(true);

        ShipFocus.SetActive(false);
        DronesFocus.SetActive(false);
        UpgradesFocus.SetActive(false);
        AsiniumFocus.SetActive(true);
    }

}
