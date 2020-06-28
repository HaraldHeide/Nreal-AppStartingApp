using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStartingApp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartingApp("com.CornyRabbit.ARCAR");
    }

    // Update is called once per frame
    void StartingApp(string newApp)
    {
        bool fail = false;
        string bundleId = newApp; // your target bundle id

        AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ca = up.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject packageManager = ca.Call<AndroidJavaObject>("getPackageManager");

        AndroidJavaObject launchIntent = null;
        try
        {
            launchIntent = packageManager.Call<AndroidJavaObject>("getLaunchIntentForPackage", bundleId);
        }
        catch (System.Exception e)
        {
            fail = true;
        }

        if (fail || launchIntent == null)
        { //open app in store
            Application.OpenURL("https://google.com");
            //Application.OpenURL("market://details?id=YOUR.APP.BUNDLE.HERE");
        }
        else //open the app
            ca.Call("startActivity", launchIntent);

        up.Dispose();
        ca.Dispose();
        packageManager.Dispose();
        launchIntent.Dispose();
    }
}
