using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Canvas_Log : MonoBehaviour
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
    public Button btnLogin;
    public System.Action<string, string> onClickLogin;

    private void Awake()
    {
        this.btnLogin.onClick.AddListener(() =>
        {
            string id = this.inputId.text;
            string password = this.inputPassword.text;
            Debug.LogFormat("id: {0}", id);
            Debug.LogFormat("password: {0}", password);

            this.onClickLogin(id, password);
        });
    }

    void Start()
    {
        
    }
}