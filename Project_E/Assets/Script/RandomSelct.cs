using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomSelct : MonoBehaviour
{

    public List<Card> deck = new List<Card>(); //카드 종류를 담을 리스트
    public int total = 0;
    public List<Card> result = new List<Card>();

    public void ResultSelect()
    {
        result.Add(RandomCard());
    }


    //가중치 랜덤으로 특정 등급은 더 적게 나오게 설정
    public Card RandomCard()
    {
        int weight = 0;
        int selectNum = 0;

        selectNum = Mathf.RoundToInt(total * Random.Range(0.0f, 1.0f));

        for (int i = 0; i < deck.Count; i++)
        {
            weight += deck[i].weight;
            if (selectNum <= weight)
            {
                Card temp = new Card(deck[i]);
                return temp;
            }
        }

        return null;
    }

    void Start()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            total += deck[i].weight; //덱 출력
        }
    }

    void Update()
    {
        
    }
}
