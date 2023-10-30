using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class StartButtonControl : MonoBehaviour
{
    //public Button button_open_pad;
    public GameObject uiPanel;
    private bool isPanelActive = false;

    void Start()
    {
        // �ʱ⿡ UI �г� ��Ȱ��ȭ
        uiPanel.SetActive(false);
    }

    public void TogglePanel()
    {
        // ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
        isPanelActive = !isPanelActive; // ���� ���¸� �ݴ�� ����

        // UI �г� Ȱ��ȭ/��Ȱ��ȭ
        uiPanel.SetActive(isPanelActive);
    }
}