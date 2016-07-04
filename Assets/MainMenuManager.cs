using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//Get the scene manager

public class MainMenuManager : MonoBehaviour {
    Archive Ark;//Archive Link
    public string RoomName;//Room name for unloading
	// Use this for initialization
	void Start () {
        GameObject g = GameObject.Find("Archive");//Find the archive object
        Ark = (Archive)g.GetComponent("Archive");//Pass the archiver
	}
	
	// Update is called once per frame
	void Update () {
	
	}public void ChangeRoom(int Room)
    {
        SceneManager.UnloadScene(RoomName);//Scene unloader
        SceneManager.LoadScene(Room, LoadSceneMode.Additive);//load the scene in additive
    }
}
