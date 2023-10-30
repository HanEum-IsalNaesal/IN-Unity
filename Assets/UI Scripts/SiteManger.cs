using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiteManger : MonoBehaviour
{
    public void OnClick_OpenURL()
    {
        Application.OpenURL("www.youtube.com");
    }

    public void OnClick_OpenURL_str(string URL)
    {
        Application.OpenURL(URL);
    }
}
