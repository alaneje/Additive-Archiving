using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReadOnlyRoom : MonoBehaviour {
    Archive Ark;//Archive Link
    public Text Read;//Read thing for the ui

    // Use this for initialization
    void Start () {
        GameObject g = GameObject.Find("Archive");//Find the archive object
        Ark = (Archive)g.GetComponent("Archive");//Pass the archiver

    }

    // Update is called once per frame
    void Update () {
        Read.text = "Number" + Ark.StoredData;//Read number
	}
}
