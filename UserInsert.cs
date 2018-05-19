using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using UnityEngine;

public class UserInsert : MonoBehaviour {
    public GameObject usernameObject;
    public GameObject passwordObject;
    public GameObject passwordVerificationObject;
    public GameObject emailObject;

    public Text ErrorLog;
    public GameObject errorLogObject;
    

    public GameObject RegisterScreen;
    public GameObject LoginScreen;

    private string inputUserName;
    private string inputPassword;
    private string inputPasswordVerification;
    private string inputEmail;
    
    

    string CreateUserURL = "http://localhost/rpg/InsertUser.php";
    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {


        if (inputPassword == inputPasswordVerification && Input.GetKeyDown(KeyCode.Return))
        {
            CreateUser(inputUserName, inputEmail, inputPassword, inputPasswordVerification);
            RegisterScreen.SetActive(false);
            LoginScreen.SetActive(true);
        }
        if (inputPassword != inputPasswordVerification && Input.GetKeyDown(KeyCode.Return))
        {
            Show("Password is not valid");
        }
        else { Hide(); }


            if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (usernameObject.GetComponent<InputField>().isFocused)
            {
                emailObject.GetComponent<InputField>().Select();
            }
            if (emailObject.GetComponent<InputField>().isFocused)
            {
                passwordObject.GetComponent<InputField>().Select();
            }
            if (passwordObject.GetComponent<InputField>().isFocused)
            {
                passwordVerificationObject.GetComponent<InputField>().Select();
            }
        }

  

        
        
        inputUserName = usernameObject.GetComponent<InputField>().text;
        inputEmail = emailObject.GetComponent<InputField>().text;
        inputPassword = passwordObject.GetComponent<InputField>().text;
        inputPasswordVerification = passwordVerificationObject.GetComponent<InputField>().text;
    }

    public void CreateUser(string username, string email, string password, string passwordVerification)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
      
        form.AddField("emailPost", email);

        form.AddField("passwordPost", password);

        form.AddField("passwordVerificationPost", passwordVerification);

        WWW www = new WWW(CreateUserURL, form);
    }

    public void Show(string message)
    {
        ErrorLog.text = message;
        errorLogObject.SetActive(true);
    }

    public void Hide()
    {
        errorLogObject.SetActive(false);
    }

   
}
