using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Canvas_Sign : MonoBehaviour
{
    public Button button_close;

    public void Init()
    {

    }

    public void Open()
    {
        this.gameObject.SetActive(true);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public TMP_InputField inputId;
    public TMP_InputField inputPassword;
    public TMP_InputField inputPassword_check;
    public TMP_InputField inputName;

    public Button btnSignup;
    public System.Action<string, string, string> onClickSignup;

    private void Awake()
    {
        this.btnSignup.onClick.AddListener(() =>
        {
            string id = this.inputId.text;
            string password = this.inputPassword.text;
            string password_check = this.inputPassword_check.text;
            string name = this.inputName.text;

            Debug.LogFormat("id: {0}", id);
            Debug.LogFormat("password: {0}", password); 
            Debug.LogFormat("name: {0}", name);

            this.onClickSignup(id, password, name);
        });
    }

    void Start()
    {

    }
}