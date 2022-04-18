using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    private void Awake()
    {
        controller = this;
    }

    [Header("��ñ�������")]
    public int dieChestCount;

    [Header("�ܹ����ڵı�������")]
    public int number;

    public void SetMaxChestCount(int number)
    {
        this.number = number;
    }
    /// <summary>
    /// ������������
    /// </summary>
    public void AddDieChestCount()
    {
        dieChestCount++;
        UIController.contronller.SetDieChestCount(dieChestCount);
        if (dieChestCount == number)
        {
            UIController.contronller.ShowResultPanel();
            //��Ϸ����
            Debug.Log("��Ϸ����");
        }
    }
   

    // Start is called before the first frame update
    void Start()
    {
        UIController.contronller.SetChestCount(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
