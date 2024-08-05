using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

public class NextLevel : MonoBehaviour
{

    [SerializeField] private Button nextLevelButton;

    public int nextLevel;

    private void Start()
    {
        nextLevelButton.onClick.AddListener(LoadNextLevel);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("GameScene_Level" + nextLevel.ToString());
        Loader.Load((Loader.Scene)System.Enum.Parse(typeof(Loader.Scene), "GameScene_Level" + nextLevel.ToString()));
    }
    
}
