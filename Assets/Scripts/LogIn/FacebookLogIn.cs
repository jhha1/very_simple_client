
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
//using Facebook.Unity;



public class FacebookLogIn : MonoBehaviour
{

    public Image userPic;

    // Use this for initialization
    void Awake()
    {/*
            if( !FB.IsInitialized)
            {
                FB.Init(Initialize, OnHideUnity);
            }
            else
            {

            }
       */     
    }

    void Initialize()
    {
        /*
        if (FB.IsInitialized)
        {
            FB.ActivateApp();
        }
        else
        {
            Debug.Log("Failed to Initalize the Facebook SDK");
        }*/
    }

    // Update is called once per frame
    public void LogOut()
    {
        //FB.LogOut();
    }

    /*
    private void AuthCallbackLogin(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
            Debug.Log(aToken.UserId);
            foreach (string perm in aToken.Permissions)
            {
                Debug.Log(perm);
            }
        }
        else
        {
            Debug.Log("User cancelled login");
        }
    }

    void SetInit()
    {
        if (FB.IsLoggedIn)
        {
            Debug.Log("FB is logged in");
        }
        else
        {
            Debug.Log("FB is not logged In");
        }
        DealWithFBMenus(FB.IsLoggedIn);
    }

    void OnHideUnity(bool isGameShown)
    {
        if (!isGameShown)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void LogIn()
    {
        List<string> permissions = new List<string>();
        permissions.Add("public_profile");
        permissions.Add("email");
        permissions.Add("user_friends");

        FB.LogInWithReadPermissions(permissions, AuthCallBack);
    }

    void AuthCallBack(IResult result)
    {
        if (result.Error != null)
        {
            Debug.Log(result.Error);
        }
        else
        {
            if (FB.IsLoggedIn)
            {
                Debug.Log("FB is logged in");
                var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
                Debug.Log(aToken.UserId);
                foreach (string perm in aToken.Permissions)
                {
                    Debug.Log(perm);
                }
            }
            else
            {
                Debug.Log("FB is not logged in");
            }
            DealWithFBMenus(FB.IsLoggedIn);
        }
    }

    void DealWithFBMenus(bool isLoggedIn)
    {
        if (isLoggedIn)
        {
            FB.API("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
            FB.API("/me?picture?type=square&height=128&width=128", HttpMethod.GET, DisplayProfilePic);
        }
        else
        {

        }
    }

    void DisplayUsername(IResult result)
    {
        if (result.Error == null)
        {
            Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!! UserNAme : " + result.ResultDictionary["first_name"]);
        }
        else
        {
            Debug.Log(result.Error);
        }
    }

    void DisplayProfilePic(IGraphResult result)
    {
        if (result.Texture != null)
        {
            Image ProfilePic = userPic.GetComponent<Image>();
            ProfilePic.sprite = Sprite.Create(result.Texture, new Rect(0, 0, 128, 128), new Vector2());
        }
    }

   */
}
