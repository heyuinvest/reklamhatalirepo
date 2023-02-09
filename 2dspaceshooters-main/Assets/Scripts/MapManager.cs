using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MapManager : MonoBehaviour

{
    // Start is called before the first frame update
    public List<Button> levelButton;
    public List<GameObject> RewardScrn;

    public bool delete;

    void Start()
    {
        if(delete)
        
            PlayerPrefs.DeleteAll();
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");

        for (int i = 0; i < levelButton.Count; i++)
        {
            if (i<= saveIndex)
            {
                levelButton[1].interactable = true;
                
            }
            else 
            {
                levelButton[i].interactable = false ;
                

            }
        }
        

    }

    // Update is called once per frame
   
   public void LevelSelect()
   {
    int level = int.Parse(EventSystem.current.currentSelectedGameObject.name);
    SceneManager.LoadScene(level);
   }

    public void RewardScreen()
    {
        int rew = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        RewardScrn[rew].SetActive(true);
    }
}
