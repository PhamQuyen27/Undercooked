using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        MainMenuScene,
        LevelSelection,
        GameScene_Level1,
        GameScene_Level2,
        GameScene_Level3,
        GameScene_Level4,
        GameScene_Level5,
        GameScene_Level6,
        LoadingScene
    }

    private static Scene targetScene;

    public static void Load (Scene targetScene)
    {
        Loader.targetScene = targetScene;

        SceneManager.LoadScene(Scene.LoadingScene.ToString());


    }

    public static void LoaderCallback()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}
