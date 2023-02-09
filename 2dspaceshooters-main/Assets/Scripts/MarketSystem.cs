using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MarketSystem : MonoBehaviour
{
    public static int selected;
    public int shipPrice1, shipPrice2, shipPrice3, shipPrice4, shipPrice5, shipPrice6, shipPrice7;
    public Button buyButton1, buyButton2, buyButton3, buyButton4, buyButton5, buyButton6, buyButton7;
    public GameObject buyButtonS1, buyButtonS2, buyButtonS3, buyButtonS4, buyButtonS5, buyButtonS6, buyButtonS7;

    public GameObject selectButton1, selectButton2, selectButton3, selectButton4, selectButton5, selectButton6, selectButton7;

    public int buybutClose2, buybutClose3, buybutClose4, buybutClose5, buybutClose6, buybutClose7;

    //public GameObject selecetedButton1, selectedButton2, selecetedButton3, selectedButton4, selectedButton5, selectedButton6, selectedButton7;


    //public Button startButton;

    public int goldMenBuy,toolsMenBuy, droneUpgPrice, Upgr1, Upgr2 , shipUpgPrice, sUpgr1, sUpgr2, shipUpgTools;
    public float droneDensSpeed, shipDensSpeed;

    public TextMeshProUGUI dronePrice, Upgr1T, Upgr2T, shipPrice, sUpgr1T, sUpgr2T, shipTools;
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.HasKey("attckDens"))
        {
            droneDensSpeed = PlayerPrefs.GetFloat("attckDens");
        }
        else
            droneDensSpeed = 2;

        if (PlayerPrefs.HasKey("droneUpgPrice"))
        {
            droneUpgPrice = PlayerPrefs.GetInt("droneUpgPrice");
        }
        else
            droneUpgPrice = 2000;


        if (PlayerPrefs.HasKey("droneUpgPrice"))
        {
            droneUpgPrice = PlayerPrefs.GetInt("droneUpgPrice");

            Upgr1 = PlayerPrefs.GetInt("Upgr11");
            Upgr2 = PlayerPrefs.GetInt("Upgr22");
        }
        else
        {
            Upgr1 = 1;
            Upgr2 = 2;

        }
        ///////////////////////////////////////
        if (PlayerPrefs.HasKey("shipAttackDens"))
        {
            shipDensSpeed = PlayerPrefs.GetFloat("shipAttackDens");
        }
        else
            shipDensSpeed = 0.5f;

        if (PlayerPrefs.HasKey("shipUpgPrice"))
        {
            shipUpgPrice = PlayerPrefs.GetInt("shipUpgPrice");
        }
        else
            shipUpgPrice = 3000;

        if (PlayerPrefs.HasKey("shipUpgTools"))
        {
            shipUpgTools = PlayerPrefs.GetInt("shipUpgTools");
        }
        else
            shipUpgTools = 2000;

        if (PlayerPrefs.HasKey("shipUpgPrice"))
        {
            shipUpgPrice = PlayerPrefs.GetInt("shipUpgPrice");
            shipUpgTools = PlayerPrefs.GetInt("shipUpgTools");

            sUpgr1 = PlayerPrefs.GetInt("sUpgr11");
            sUpgr2 = PlayerPrefs.GetInt("sUpgr22");
        }
        else
        {
            sUpgr1 = 1;
            sUpgr2 = 2;

        }
        //////////////////////////////////////////////
        if (PlayerPrefs.HasKey("buybutClos2"))
        {
            buybutClose2 = 1;
        }
        else
            buybutClose2 = 0;

        if (PlayerPrefs.HasKey("buybutClos3"))
        {
            buybutClose3 = 1;
        }
        else
            buybutClose3 = 0;

        if (PlayerPrefs.HasKey("buybutClos4"))
        {
            buybutClose4 = 1;
        }
        else
            buybutClose4 = 0;

        if (PlayerPrefs.HasKey("buybutClos5"))
        {
            buybutClose5 = 1;
        }
        else
            buybutClose5 = 0;

        if (PlayerPrefs.HasKey("buybutClos6"))
        {
            buybutClose6 = 1;
        }
        else
            buybutClose6 = 0;

        if (PlayerPrefs.HasKey("buybutClos7"))
        {
            buybutClose7 = 1;
        }
        else
            buybutClose7 = 0;


        if (PlayerPrefs.HasKey("select"))
        {
            selected = PlayerPrefs.GetInt("select");
        }
        else
            selected = 1;
        

    }

    // Update is called once per frame
    void Update()
    {

        dronePrice.text = droneUpgPrice.ToString();

        Upgr1T.text = Upgr1.ToString();
        Upgr2T.text = Upgr2.ToString();

        shipPrice.text = shipUpgPrice.ToString();
        shipTools.text = shipUpgTools.ToString();

        sUpgr1T.text = sUpgr1.ToString();
        sUpgr2T.text = sUpgr2.ToString();

        if (buybutClose2 == 1)
        {
            buyButtonS2.SetActive(false);
        }

        if (buybutClose3 == 1)
        {
            buyButtonS3.SetActive(false);
        }

        if (buybutClose4 == 1)
        {
            buyButtonS4.SetActive(false);
        }

        if (buybutClose5 == 1)
        {
            buyButtonS5.SetActive(false);
        }

        if (buybutClose6 == 1)
        {
            buyButtonS6.SetActive(false);
        }

        if (buybutClose7 == 1)
        {
            buyButtonS7.SetActive(false);
        }

        goldMenBuy = PlayerPrefs.GetInt("goldC");
        toolsMenBuy = PlayerPrefs.GetInt("toolsC");
        //droneDensSpeed = PlayerPrefs.GetFloat("attckDens");

        if (goldMenBuy > shipPrice2)
        {
            buyButton2.interactable = true;
        }

        if (goldMenBuy > shipPrice3)
        {
            buyButton3.interactable = true;
        }

        if (goldMenBuy > shipPrice4)
        {
            buyButton4.interactable = true;
        }

        if (goldMenBuy > shipPrice5)
        {
            buyButton5.interactable = true;
        }

        if (goldMenBuy > shipPrice6)
        {
            buyButton6.interactable = true;
        }

        if (goldMenBuy > shipPrice7)
        {
            buyButton7.interactable = true;
        }

        ////////////////
        ///
        if(selected == 1)
        {
            selectButton1.SetActive(false);

            selectButton2.SetActive(true);
            selectButton3.SetActive(true);
            selectButton4.SetActive(true);
            selectButton5.SetActive(true);
            selectButton6.SetActive(true);
            selectButton7.SetActive(true);
        }
        if (selected == 2)
        {
            selectButton1.SetActive(true);

            selectButton2.SetActive(false);
            selectButton3.SetActive(true);
            selectButton4.SetActive(true);
            selectButton5.SetActive(true);
            selectButton6.SetActive(true);
            selectButton7.SetActive(true);
        }
        if (selected == 3)
        {
            selectButton1.SetActive(true);

            selectButton2.SetActive(true);
            selectButton3.SetActive(false);
            selectButton4.SetActive(true);
            selectButton5.SetActive(true);
            selectButton6.SetActive(true);
            selectButton7.SetActive(true);
        }
        if (selected == 4)
        {
            selectButton1.SetActive(true);

            selectButton2.SetActive(true);
            selectButton3.SetActive(true);
            selectButton4.SetActive(false);
            selectButton5.SetActive(true);
            selectButton6.SetActive(true);
            selectButton7.SetActive(true);
        }
        if (selected == 5)
        {
            selectButton1.SetActive(true);

            selectButton2.SetActive(true);
            selectButton3.SetActive(true);
            selectButton4.SetActive(true);
            selectButton5.SetActive(false);
            selectButton6.SetActive(true);
            selectButton7.SetActive(true);
        }
        if (selected == 6)
        {
            selectButton1.SetActive(true);

            selectButton2.SetActive(true);
            selectButton3.SetActive(true);
            selectButton4.SetActive(true);
            selectButton5.SetActive(true);
            selectButton6.SetActive(false);
            selectButton7.SetActive(true);
        }
        if (selected == 7)
        {
            selectButton1.SetActive(true);

            selectButton2.SetActive(true);
            selectButton3.SetActive(true);
            selectButton4.SetActive(true);
            selectButton5.SetActive(true);
            selectButton6.SetActive(true);
            selectButton7.SetActive(false);
        }
    }

    public void buybut1()
    {
        goldMenBuy -= shipPrice1;
        
        selected = 1;
        PlayerPrefs.SetInt("select", selected);

        buyButtonS1.SetActive(false);
    }
    public void buybut2()
    {
        if(goldMenBuy >= shipPrice2)
        { 
        selected = 2;
        PlayerPrefs.SetInt("select", selected);

        goldMenBuy -= shipPrice2;
        PlayerPrefs.SetInt("goldC", goldMenBuy);
    
        buyButtonS2.SetActive(false);

        buybutClose2 = 1;
        PlayerPrefs.SetInt("buybutClos2", buybutClose2);
        }
    }
    public void buybut3()
    {
        if (goldMenBuy >= shipPrice3)
        {
            selected = 3;
            PlayerPrefs.SetInt("select", selected);

            goldMenBuy -= shipPrice3;
            PlayerPrefs.SetInt("goldC", goldMenBuy);

            buyButtonS3.SetActive(false);

            buybutClose3 = 1;
            PlayerPrefs.SetInt("buybutClos3", buybutClose3);
        }

    }
    public void buybut4()
    {
        if (goldMenBuy >= shipPrice4)
        {
            selected = 4;
        PlayerPrefs.SetInt("select", selected);

        goldMenBuy -= shipPrice4;
        PlayerPrefs.SetInt("goldC", goldMenBuy);
      
        buyButtonS4.SetActive(false);

        buybutClose4 = 1;
        PlayerPrefs.SetInt("buybutClos4", buybutClose4);
        }
    }
    public void buybut5()
    {
        if (goldMenBuy >= shipPrice5)
        {
            selected = 5;
        PlayerPrefs.SetInt("select", selected);

        goldMenBuy -= shipPrice5;
        PlayerPrefs.SetInt("goldC", goldMenBuy);
      
        buyButtonS5.SetActive(false);

        buybutClose5 = 1;
        PlayerPrefs.SetInt("buybutClos5", buybutClose5);
        }
    }
    public void buybut6()
    {
        if (goldMenBuy >= shipPrice6)
        {
            selected = 6;
            PlayerPrefs.SetInt("select", selected);

            goldMenBuy -= shipPrice6;
            PlayerPrefs.SetInt("goldC", goldMenBuy);

            buyButtonS6.SetActive(false);

            buybutClose6 = 1;
            PlayerPrefs.SetInt("buybutClos6", buybutClose6);
        }
    }
    public void buybut7()
    {
        if (goldMenBuy >= shipPrice7)
        {
            selected = 7;
            PlayerPrefs.SetInt("select", selected);

            goldMenBuy -= shipPrice7;
            PlayerPrefs.SetInt("goldC", goldMenBuy);

            buyButtonS7.SetActive(false);

            buybutClose7 = 1;
            PlayerPrefs.SetInt("buybutClos7", buybutClose7);
        }
    }
     /// <summary>
     /// ///////////////////////////////////
     /// </summary>
    public void ship1()
    {
        selected = 1;
        PlayerPrefs.SetInt("select", selected);
    }
    public void ship2()
    {
        selected = 2;
        PlayerPrefs.SetInt("select", selected);
    }
    public void ship3()
    {
        selected = 3;
        PlayerPrefs.SetInt("select", selected);
    }
    public void ship4()
    {
        selected = 4;
        PlayerPrefs.SetInt("select", selected);
    }
    public void ship5()
    {
        selected = 5;
        PlayerPrefs.SetInt("select", selected);
    }
    public void ship6()
    {
        selected = 6;
        PlayerPrefs.SetInt("select", selected);
    }
    public void ship7()
    {
        selected = 7;
        PlayerPrefs.SetInt("select", selected);
    }


    public void DroneUpgr()
    {
        if(Upgr1 <= 9 && goldMenBuy >= droneUpgPrice) 
        {
        goldMenBuy -= droneUpgPrice;
        PlayerPrefs.SetInt("goldC", goldMenBuy);

        droneUpgPrice += 2000;
        PlayerPrefs.SetInt("droneUpgPrice", droneUpgPrice);

        droneDensSpeed -= 0.2f;
        PlayerPrefs.SetFloat("attckDens", droneDensSpeed);

        Upgr1 += 1;
        Upgr2 += 1;
        PlayerPrefs.SetInt("Upgr11", Upgr1);
        PlayerPrefs.SetInt("Upgr22", Upgr2);
        }

    }

    public void ShipUpgr()
    {
        if (sUpgr1 <= 9 && goldMenBuy >= shipUpgPrice && toolsMenBuy >= shipUpgTools)
        {
            goldMenBuy -= shipUpgPrice;
            PlayerPrefs.SetInt("goldC", goldMenBuy);

            shipUpgPrice += 2000;
            PlayerPrefs.SetInt("shipUpgPrice", shipUpgPrice);

            toolsMenBuy -= shipUpgTools;
            PlayerPrefs.SetInt("toolsC", toolsMenBuy);

            shipUpgTools += 2000;
            PlayerPrefs.SetInt("shipUpgTools", shipUpgTools);

            shipDensSpeed -= 0.05f;
            PlayerPrefs.SetFloat("shipAttackDens", shipDensSpeed);

            sUpgr1 += 1;
            sUpgr2 += 1;
            PlayerPrefs.SetInt("sUpgr11", sUpgr1);
            PlayerPrefs.SetInt("sUpgr22", sUpgr2);
        }

    }

    public void prefsDelete()
    {
        PlayerPrefs.DeleteAll();
    }
}