using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class StartButtonControl : MonoBehaviour
{
    public GameObject uiToActivate; // 시작 버튼을 눌렀을 때 활성화할 UI
    private bool uiActive = false;

    void Update()
    {
        if (XRSettings.isDeviceActive) // Oculus 장치가 활성화되어 있는지 확인
        {
            // Oculus Touch 컨트롤러의 Start 버튼을 감지
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (!uiActive) // UI가 활성화되지 않은 경우 UI를 활성화
                {
                    uiToActivate.SetActive(true);
                    uiActive = true;
                }
                else // UI가 이미 활성화된 경우 UI를 비활성화
                {
                    uiToActivate.SetActive(false);
                    uiActive = false;
                }
            }
        }
    }
}
