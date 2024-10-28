using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Scene1()
    {
        UnityEngine.Debug.Log("Scene1 geldi");
        SceneManager.LoadScene("Scene1");
    }
    public void Scene2()
    {
        UnityEngine.Debug.Log("Scene2 geldi");
        SceneManager.LoadScene("Scene2");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Scene4");
    }
    public void Scene5()
    {
        SceneManager.LoadScene("Scene5");
    }
    public void Scene6()
    {
        SceneManager.LoadScene("Scene6");
    }
    public void Scene7()
    {
        SceneManager.LoadScene("Scene7");
    }


}
