using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class LevelSelection : MonoBehaviour
{
    public Level[] levels;
    public Image levelImage;
    private int levelSelected = 1;

    public void SelectLevel(int level)
    {
        levelSelected = level;
        levelImage.sprite = levels[level - 1].image;
    }

    public void PlaySelectedLevel()
    {
        ChangeScene(levels[levelSelected - 1].name);
    }

    public void ChangeScene(string SceneName)
    {
        //SceneManager.LoadScene(SceneName);
        Loader.Load((Loader.Scene)System.Enum.Parse(typeof(Loader.Scene), "GameScene_Level" + SceneName));
    }

}
