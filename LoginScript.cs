using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using UnityEngine;

public class LoginScript : MonoBehaviour {
    string LoginURL = "http://localhost/rpg/UserCheck.php";

    public GameObject email;
    public GameObject password;
    private string Email;
    private string Password;

 
  

    // Use this for initialization
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (email.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {

           StartCoroutine(CheckUser(Email, Password));
            
           
        }

       
    }

    IEnumerator CheckUser(string email, string password)
    {
        WWWForm form = new WWWForm();
       
        form.AddField("emailPost", email);

        form.AddField("passwordPost", password);

        WWW www = new WWW(LoginURL, form);

        yield return www;

        Debug.Log(www.text);
    }


}
