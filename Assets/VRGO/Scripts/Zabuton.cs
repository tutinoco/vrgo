﻿
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Zabuton : UdonSharpBehaviour
{
    [Header("目に見えるモデルを設定します")]
    [SerializeField] private GameObject model;
    
    void Start()
    {
    }

    void Update()
    {
        Vector3 p = gameObject.transform.localPosition;
        gameObject.transform.localPosition = new Vector3(0,Mathf.Max(Mathf.Min(p.y,0.7f),0.0f),0);
        model.gameObject.transform.localPosition = gameObject.transform.localPosition;
    }
}
