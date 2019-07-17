using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class MenuManager : MonoBehaviour
{
    public int DefaultLoadLevel = 2;
    public static int LoadLevel { get; private set; }
    
    // Update is called once per frame
    void Start()
    {
        LoadLevel = DefaultLoadLevel;
        UnityEngine.RemoteSettings.Completed += HandleRemoteSettings;

        UnityEngine.SceneManagement.SceneManager.LoadScene(LoadLevel);
    }

    private void HandleRemoteSettings(bool wasUpdatedFromServer, bool settingsChanged, int serverResponse) {
        LoadLevel = UnityEngine.RemoteSettings.GetInt("start_level", DefaultLoadLevel);

    }
}
