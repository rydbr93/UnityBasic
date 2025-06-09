using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListTest1 : MonoBehaviour
{
    List<string> characterList = new List<string>();

    int n;

    public void Gacha() // characterList 0 ~ 9 -> 총 10개
    {
        characterList.Add("고은식"); // 0번
        characterList.Add("권도영"); // 1번
        characterList.Add("권우중"); // 2번
        characterList.Add("김경빈"); // 3번
        characterList.Add("김귀령"); // 4번
        characterList.Add("김도형"); // 5번
        characterList.Add("김민영"); // 6번
        characterList.Add("김상준"); // 7번
        characterList.Add("김성현"); // 8번
        characterList.Add("김예성"); // 9번
        characterList.Add("김재협");
        characterList.Add("김지선");
        characterList.Add("김지원");
        characterList.Add("김태현");
        characterList.Add("김한나");
        characterList.Add("노민식");
        characterList.Add("목승환");
        characterList.Add("문혜준");
        characterList.Add("민송희");
        characterList.Add("박건태");
        characterList.Add("박민수");
        characterList.Add("박성빈");
        characterList.Add("박시원");
        characterList.Add("박재완");
        characterList.Add("박재환");
        characterList.Add("박준석");
        characterList.Add("박지원");
        characterList.Add("박현아");
        characterList.Add("배소정");
        characterList.Add("백승헌");
        characterList.Add("손석현");
        characterList.Add("신수용");
        characterList.Add("신승환");
        characterList.Add("신채현");
        characterList.Add("안정환");
        characterList.Add("양승화");
        characterList.Add("양현지");
        characterList.Add("엄지성");
        characterList.Add("원대연");
        characterList.Add("원중완");
        characterList.Add("윤사무엘");
        characterList.Add("이강민");
        characterList.Add("이경식");
        characterList.Add("이규진");
        characterList.Add("이동욱");
        characterList.Add("이민호");
        characterList.Add("이상록");
        characterList.Add("이상엽");
        characterList.Add("이성훈");
        characterList.Add("이승준");
        characterList.Add("이원림");
        characterList.Add("이유경");
        characterList.Add("이윤호");
        characterList.Add("이준모");
        characterList.Add("이창호");
        characterList.Add("이채성");
        characterList.Add("이호범");
        characterList.Add("장재호");
        characterList.Add("정승원");
        characterList.Add("정은교");
        characterList.Add("정호진");
        characterList.Add("조규현");
        characterList.Add("조민식");
        characterList.Add("조성재");
        characterList.Add("조인영");
        characterList.Add("조지현");
        characterList.Add("조형민");
        characterList.Add("차정훈");
        characterList.Add("천지수");
        characterList.Add("최문석");
        characterList.Add("최현석");
        characterList.Add("한세웅");
        characterList.Add("허재영");
        characterList.Add("홍서빈");


        for (int i = 0; i<1; i++) //1회 반복하여 뽑기 출력
        {
            int rand = Random.Range(0,characterList.Count); //rand 변수의 값은 0부터 characterList의 개수 중 랜덤 출력
            print(characterList[rand]);
            characterList.RemoveAt(rand); // 값 지우고 다시 반복
        }


    }

    /*
    private void start()
    {
        int randomValue = Random.Range(0, 9); // 0~9까지 총 10번 중 랜덤 출력

        for (int n = 1; n < 11; n++)
        {
            Debug.Log(n + "번째 학생 캐릭터는" + characterList[randomValue] + "님 캐릭터 입니다.");
        }
    }
    */

}