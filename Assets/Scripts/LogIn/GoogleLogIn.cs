using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System.Threading;
using Assets.Scripts;

public class GoogleLogIn : MonoBehaviour
{

    public Text tx_log;
    public Text tx_userName;

    // Use this for initialization
    void Start()
    {
//#if UNITY_ANDROID
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
				.EnableSavedGames()
				.Build();

			PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
//#elif UNITY_IOS
//		GameCenterPlatform.ShowDefaultAchievenmentCompletionBanner(true);
//#endif
    }

    public void LogIn()
    {

        Social.localUser.Authenticate((bool success) => {
            if (success)
            {
                Debug.Log("!!!!!!!!!!!! You've successfully logged in. ");
                Debug.Log("id:" + Social.localUser.id
                            + ",name:" + Social.localUser.userName);

               // LogInGameServer( Social.localUser.id );
            }
            else {
                Debug.Log("Login failed for some reason: " + Social.Active);
            }

        });
    }

    private void LogInGameServer(string userId)
    {
        Debug.Log("LogInGameServer called. USERID: " + userId);

        LogInRequest request = new LogInRequest();
        request.PID = (int)PROTOCOL.PID.LOGIN;
        request.PlatformType = (int)LogInRequest.PLATFORM_TYPE.GOOGLE;
        request.UserId = userId;
        request.DeviceId = string.Empty;

        Http http = gameObject.AddComponent<Http>();
        http.Send(request);
        string responseString = http.GetResponseString();

        LogInResponse response = JsonUtility.FromJson<LogInResponse>(responseString);
        Debug.Log("resprotocol : " + response.ToString() + "," + response.CODE + "," + response.MSG);
    }

    public void LogOut()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
        Debug.Log("LogOut successfully ");
    }


}
