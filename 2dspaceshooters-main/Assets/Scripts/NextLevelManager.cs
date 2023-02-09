using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class NextLevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int buildIndex= 50;

    public static int Gold;

    public int GoldCount;

    public TextMeshProUGUI GoldCountText;

    public static int Tools;

    public int ToolsCount;

    public TextMeshProUGUI ToolsCountText;
    void Start()
    {

if (PlayerPrefs.HasKey("goldC"))
        {
            Gold = PlayerPrefs.GetInt("goldC");
            Debug.Log("altın yüklendi");
        }
        else
        {
            Gold = 0;
            Debug.Log("altın yüklenmedi");
        }


        if (PlayerPrefs.HasKey("toolsC"))
        {
            Tools = PlayerPrefs.GetInt("toolsC");
        }
        else
            Tools = 0;

        buildIndex = SceneManager.GetActiveScene().buildIndex;
        TMP_Text levelText = GameObject.Find("LevelText").GetComponent<TMP_Text>();
        levelText.text = "Level_"+buildIndex.ToString();


        //Gold = PlayerPrefs.GetInt("goldC");
        //Tools = PlayerPrefs.GetInt("toolsC");

    }

    // Update is called once per frame
    void Update()
    {
        GoldCountText.text = GoldCount.ToString();

        ToolsCountText.text = ToolsCount.ToString();
    }
    public void NextLevel()
    {

        
        Time.timeScale = 1;

        WaveSpawner.isGameFinish = false;
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");

        Gold += GoldCount;
        Tools += ToolsCount;

        PlayerPrefs.SetInt("goldC", Gold);
        PlayerPrefs.SetInt("toolsC", Tools);

        if (buildIndex > saveIndex)
        {
            PlayerPrefs.SetInt("SaveIndex",buildIndex);
        }
        if(buildIndex == 50)
        {
            SceneManager.LoadScene(51);
            
        }
        else{
            SceneManager.LoadScene(buildIndex+1);
        }
    }

    
}
