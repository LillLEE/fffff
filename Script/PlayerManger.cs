using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManger : MonoBehaviour
{
    #region Singleton

    public static PlayerManger instance;  //플레이어 메니저를 인스턴스라고 지정

     void Awake()
    {
        instance = this;   
    }
    #endregion

    public GameObject player;
         
}

