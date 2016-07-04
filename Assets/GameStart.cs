using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;//Get the scene manager
public class GameStart : MonoBehaviour
{
  public  string Scene;//quick scene changer
void Start()
    {

        SceneManager.LoadScene(Scene, LoadSceneMode.Additive);//load the scene in additive
    }
}
