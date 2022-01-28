using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour //LoadingScreen
{

    public GameObject loadingScreen;
    public Slider slider;

    public void LoadLevel(int sceneIndex) 
    {
        StartCoroutine(LoadAsync(sceneIndex));       
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;
            
            yield return null;
        }
    }
}

    
//Ne sais pas si il faut s'attarder sur ce script ? (responsabilité unique par classe)