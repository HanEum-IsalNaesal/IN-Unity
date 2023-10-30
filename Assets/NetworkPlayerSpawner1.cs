using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerSpawner1 : MonoBehaviourPunCallbacks

{
    private GameObject spawnedPlayerPrefab1; // PlayerPrefab 게임 개체 변수
    

    //room 재정의

    //Room 입장 시 호출
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        spawnedPlayerPrefab1 = PhotonNetwork.Instantiate("VRplayerNetwork", transform.position, transform.rotation); //네트워크 플레이어 프리팹 인스턴스화

    }

    //room 퇴장 시 호출 -> Player 비활성화 및 제거
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab1);
    }


}
