using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class MainManager : MonoBehaviour
{
    public GameObject SettingPanel,ShopPanel,Ships,Drones,Upgrades,Asinium;
    public GameObject ShipFocus, DronesFocus, UpgradesFocus, AsiniumFocus;

    public int goldMen;
    public TextMeshProUGUI goldMenText;

    public int toolsMen;
    public TextMeshProUGUI toolsMenText;

    

    public Animator animator;
    public Animator Fadeanimator;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("goldC"))
        {
            goldMen = PlayerPrefs.GetInt("goldC");
        }
        else
            goldMen = 0;
    }

    // Update is called once per frame
    void Update()
    {
        goldMen = PlayerPrefs.GetInt("goldC");
        goldMenText.text = goldMen.ToString();

        toolsMen = PlayerPrefs.GetInt("toolsC");
        toolsMenText.text = toolsMen.ToString();



        
    }
    public void playbutton()
    {

        animator.SetBool("Start", true);
        Fadeanimator.SetBool("Start", true);
        Invoke("PlayGame", 1f);
    }

    void PlayGame()
    {
        

        SceneManager.LoadScene(51);
    }
    public void Setting()
    {
        SettingPanel.SetActive(true);
    }

    public void Shop()
    {
        ShopPanel.SetActive(true);
    }

    public void Exit()
    {
        SettingPanel.SetActive(false);
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
