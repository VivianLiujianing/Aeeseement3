using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChestNum : MonoBehaviour
{
    public static GetChestNum controller;

    private void Awake()
    {
        controller = this;
    }

    [Header("�ܹ����ڵı�������")]
    public int number;

    // Use this for initialization
    void Start()
    {
        UIController.contronller.SetChestCount(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
