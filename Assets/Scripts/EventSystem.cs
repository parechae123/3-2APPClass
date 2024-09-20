using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    //다른 스크립트에서 불러오는 구독시스템은 Event를 사용
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
