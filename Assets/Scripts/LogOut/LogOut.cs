using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Networking;
using Assets.Scripts;

public class LogOut : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}

    /*
        유저가 뒤로가기 버튼을 눌러, 게임종료 팝업에서 '종료'를 클릭했을때.
        크래시 로그아웃부분은 아직 고려 안함. 생각해 봐야함.
     */
    public void Logout()
    {
        Debug.Log("LogOut called");

        LogOutRequest request = new LogOutRequest();
        request.PID = (int)PROTOCOL.PID.LOGOUT;
        request.UserId = "GUEST17110615490700001";
        request.DeviceId = string.Empty;

        Http http = gameObject.AddComponent<Http>();
        http.Send( request );
        string responseString = http.GetResponseString();

        LogOutResponse response = JsonUtility.FromJson<LogOutResponse>(responseString);
        if(response != null)
            Debug.Log("res : " + response.ToString() + "," + response.CODE + "," + response.MSG);
    }
}
