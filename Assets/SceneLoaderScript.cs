using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderScript : MonoBehaviour
{
    private AsyncOperation asyncLoad;
    public bool activateScene = false;

    public void ActivateScene(bool state)
    {
        activateScene = state;
    }

    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(LoadSceneCoroutine(sceneIndex));
    }

    public IEnumerator LoadSceneCoroutine(int sceneIndex)
    {
        asyncLoad = SceneManager.LoadSceneAsync(sceneIndex);
        asyncLoad.allowSceneActivation = false;

        while (asyncLoad.progress < 0.9f)
        {
            yield return null;
        }
    }

    private void Update()
    {
        if (asyncLoad != null && activateScene == true && !asyncLoad.allowSceneActivation)
        {
            asyncLoad.allowSceneActivation = true;
        }
    }
}
