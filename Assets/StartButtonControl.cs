using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class StartButtonControl : MonoBehaviour
{
    public GameObject uiToActivate; // ���� ��ư�� ������ �� Ȱ��ȭ�� UI
    private bool uiActive = false;

    void Update()
    {
        if (XRSettings.isDeviceActive) // Oculus ��ġ�� Ȱ��ȭ�Ǿ� �ִ��� Ȯ��
        {
            // Oculus Touch ��Ʈ�ѷ��� Start ��ư�� ����
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (!uiActive) // UI�� Ȱ��ȭ���� ���� ��� UI�� Ȱ��ȭ
                {
                    uiToActivate.SetActive(true);
                    uiActive = true;
                }
                else // UI�� �̹� Ȱ��ȭ�� ��� UI�� ��Ȱ��ȭ
                {
                    uiToActivate.SetActive(false);
                    uiActive = false;
                }
            }
        }
    }
}
