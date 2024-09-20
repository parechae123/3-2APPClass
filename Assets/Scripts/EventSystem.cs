using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    //�ٸ� ��ũ��Ʈ���� �ҷ����� �����ý����� Event�� ���
    public static event Action<int> OnScoreChanged;
    public static event Action OnGameOver;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            OnScoreChanged?.Invoke(score);
        }
        if(score >= 100) 
        {
            OnGameOver?.Invoke();
        }
    }
}
