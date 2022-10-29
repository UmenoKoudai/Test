using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Scene : MonoBehaviour
{
    [SerializeField] GameObject _open;
    [SerializeField] GameObject _close;
    public void SceneMove(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Setactive()
    {
        _open.SetActive(true);
        _close.SetActive(false);
    }
}
