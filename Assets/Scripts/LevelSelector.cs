using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public Text levelText;

    private void Start()
    {
        levelText.text = level.ToString();
    }
    public void OpenScene()
    {
        SceneManager.LoadScene("GameScene_Level" + level.ToString());
        Loader.Load((Loader.Scene)System.Enum.Parse(typeof(Loader.Scene), "GameScene_Level" + level.ToString()));
    }
}
