//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SwipeUI : MonoBehaviour
//{
    
//    [SerializeField]
//    private Scrollbar scrollbar;                    // Scrollbar의 위치를 바탕으로 현재 페이지 검사
//    [SerializeField]
//    private Scrollbar swipeTime = 0.2f;             // 페이지가 Swipe 되는 시간
//    [SerializeField]
//    private Scrollbar swipeDistance = 50.0f;        // 페이지가 Swipe되기 위해 움직여야 하는 최소 거리

//    private float[] scrollPageValues;               //각 페이지의 위치 값 [0.0 - 1.0]
//    private float valueDistance = 0;                //각 페이지 사이의 거리
//    private int currentPage = 0;                    //현재 페이지
//    private int maxPage = 0;                        //최대 페이지
//    private float startTouchX;                      //터치 시작 위치
//    private float endTouchX;                        //터치 종료 위치
//    private bool isSwipeMode = false;               //현재 Swipe가 되고 있는지 체크
    
//    private void Awake()

//    {
//        //스크롤 되는 페이지의 각 value 값을 저장하는 배열 메모리 할당
//        scrollPageValues = new float[transform.childCount];

//        //스크롤 되는 페이지 사이의 거리
//        valueDistance = 1f / (scrollPageValues.Length - 1f);

//        //스크롤 되는 페이지의 각 value 위치 설정 [0 <= value <= 1]
//        for (int i = 0; i < scrollPageValues.Length; ++ i )
//        {
//            scrollPageValues[i] = valueDistance * i;
//        }

//        //최대 페이지의 수
//        maxPagePage = transform.childCount;
        
//    }
    

//    private void Start()
//    {
//        //최초 시작할 때 0번 페이지를 볼 수 있도록 설정
//        SetScrollBarValue(0);
//    }
    
//    private void SetScrollBarValue(int index)
//    {
//        currentPage = index;
//        scrollbar.value = scrollPageValues[index];
//    }

//    void Update()
//    {
        
//    }
//}
