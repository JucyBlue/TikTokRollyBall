using System.Collections;
using System.Data;
using System.Xml.Linq;
using TikTokLiveSharp.Client;
using TikTokLiveSharp.Events;
using TikTokLiveSharp.Events.Objects;


using TikTokLiveUnity;
using TikTokLiveUnity.Utils;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour {
    public TikTokLiveManager mgr => TikTokLiveManager.Instance;
    public Status status;
    public string hostId;

    public enum Status {
        Connected,
        Disconnected,
        Connecting
    }


    private IEnumerator Start() {
        Status status = Status.Disconnected;
        
        for (int i = 0; i < 3; i++)
            yield return null; // Wait 3 frames in case Auto-Connect is enabled

    }


    private void Update() {
        if(Input.GetKeyDown(KeyCode.C)) { mgr.ConnectToStreamAsync(hostId, Debug.LogException); }
    }

    

}