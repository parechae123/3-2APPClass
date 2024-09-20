using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCallback : MonoBehaviour
{
    private Action greetingAction;
    void Start()
    {
        greetingAction = SayHello;          //�׼� �Լ� ���
        PerformGreeting(greetingAction);    //�׼� �μ��� �Լ� ȣ��
    }
    void SayHello()
    {
        Debug.Log("Hello, world");
    }

    void PerformGreeting(Action greetingFunc) 
    {
        greetingAction?.Invoke();
    }
}
