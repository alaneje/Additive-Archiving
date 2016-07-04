using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ChangeRoomUI : MonoBehaviour {
    Archive Ark;//Archive Reference
    public Text Read;//Shows the number on screen
    public InputField Input;//Input field for changing number
	// Use this for initialization
	void Start () {
        GameObject g = GameObject.Find("Archive");//Find the archive object
        Ark = (Archive)g.GetComponent("Archive");//Pass the archiver

    }

    // Update is called once per frame
    void Update () {
        Read.text = "Number: " + Ark.StoredData;//Show number
	}
    public void ChangeOption()
    {
        int T = int.Parse(Input.text);//Parse the input field
        Ark.StoredData = T;//Transfer it to ark
    }
}
