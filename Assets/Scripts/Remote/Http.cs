using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Networking;
using Assets.Scripts;

public class Http : MonoBehaviour {

    private string URL = "http://localhost:8080/GameProject_Server/servlet";
    //private string URL = "http://112.153.210.96:8080/GameProject_Server/servlet";

    private string responseString = string.Empty;

    public void Send(object req)
    {
        StartCoroutine(SendImpl(req));
    }

    IEnumerator SendImpl(object req)
    {
        string json = JsonUtility.ToJson(req);

        WWWForm form = new WWWForm();
        form.AddField("JSON", json);

        UnityWebRequest request = UnityWebRequest.Post(URL, form);

        Debug.Log("- Request. URL[" + URL +"], DATA["+ json +"]");

        yield return request.Send();

        this.responseString = request.downloadHandler.text; // Show results as text
        Debug.Log("- Respond. DATA["+ responseString  + "]");
    }
    
    /*
    public string Send(object req)
    {
        string json = JsonUtility.ToJson(req);

        WWWForm form = new WWWForm();
        form.AddField("JSON", json);

        UnityWebRequest request = UnityWebRequest.Post(URL, form);

        Debug.Log("- Request. URL[" + URL + "], DATA[" + json + "]");

        request.Send();

        this.responseString = request.downloadHandler.text; // Show results as text
        Debug.Log("- Respond. DATA[" + responseString + "]");
        return responseString;
    }
    */
    public string GetResponseString()
    {
        return responseString;
    }
}
