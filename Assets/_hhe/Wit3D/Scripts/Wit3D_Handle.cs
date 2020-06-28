using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using UnityEngine.Video;

public partial class Wit3D_Call : MonoBehaviour
{
	public Text myHandleTextBox;
	private bool actionFound = false;
	private string theScene;

    //Generate by https://Json2Csharp.net

    void Handle(string jsonString)
	{
        Debug.Log("Json: " + jsonString);

        if (jsonString != null)
		{
            //string intent = Find_Intent(jsonString);
            #region Intent open
            #endregion

            //if (jsonString.Contains("\"name\": \"open\""))
            //{
            //    if (jsonString.Contains("\"value\": \"drivers door\""))

        }//END OF IF
    }

    //private string Find_Intent(string jsonString)
    //{
    //    if (jsonString.Contains("\"name\": \"open\""))
    //        return "open";
    //    if (jsonString.Contains("\"name\": \"close\""))
    //        return "close";
    //    if (jsonString.Contains("\"name\": \"start\""))
    //        return "start";
    //    if (jsonString.Contains("\"name\": \"stop\""))
    //        return "stop";
    //    if (jsonString.Contains("\"name\": \"colour\""))
    //        return "colour";
    //    return "";
    //}
}