using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Networking;
using Assets.Scripts;

public class GuestLogIn : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void LogIn()
    {
        Debug.Log("GuestLogin called");

        LogInRequest request = new LogInRequest();
        request.PID = (int)PROTOCOL.PID.LOGIN;
        request.PlatformType = (int)LogInRequest.PLATFORM_TYPE.GUEST;
        request.UserId = string.Empty;
        request.DeviceId = string.Empty;

        Http http = gameObject.AddComponent<Http>();
        http.Send(request);
        string responseString = http.GetResponseString();


        Debug.Log("GuestLogin responseString:" + responseString);

        LogInResponse response = JsonUtility.FromJson<LogInResponse>(responseString);
        if (response != null)
            Debug.Log("resprotocol : " + response.ToString() + "," + response.CODE + "," + response.MSG);
    }

    /*
    public void LogIn()
    {
        Debug.Log("GuestLogin called");

        StartCoroutine(CoLogIn());
    }

    IEnumerator CoLogIn()
    {
        LogInRequest request = new LogInRequest();
        request.PID = (int)PROTOCOL.PID.LOGIN;
        request.PlatformType = (int)LogInRequest.PLATFORM_TYPE.GUEST;
        request.UserId = string.Empty;
        request.DeviceId = string.Empty;

        Http http = new Http();
        yield return http.Send(request);
        string responseString = http.GetResponseString();

        LogInResponse response = JsonUtility.FromJson<LogInResponse>(responseString);
        if(response!= null)
            Debug.Log("resprotocol : " + response.ToString() + "," + response.CODE + "," + response.MSG);
    }*/
}