//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SwipeUI : MonoBehaviour
//{
    
//    [SerializeField]
//    private Scrollbar scrollbar;                    // Scrollbar�� ��ġ�� �������� ���� ������ �˻�
//    [SerializeField]
//    private Scrollbar swipeTime = 0.2f;             // �������� Swipe �Ǵ� �ð�
//    [SerializeField]
//    private Scrollbar swipeDistance = 50.0f;        // �������� Swipe�Ǳ� ���� �������� �ϴ� �ּ� �Ÿ�

//    private float[] scrollPageValues;               //�� �������� ��ġ �� [0.0 - 1.0]
//    private float valueDistance = 0;                //�� ������ ������ �Ÿ�
//    private int currentPage = 0;                    //���� ������
//    private int maxPage = 0;                        //�ִ� ������
//    private float startTouchX;                      //��ġ ���� ��ġ
//    private float endTouchX;                        //��ġ ���� ��ġ
//    private bool isSwipeMode = false;               //���� Swipe�� �ǰ� �ִ��� üũ
    
//    private void Awake()

//    {
//        //��ũ�� �Ǵ� �������� �� value ���� �����ϴ� �迭 �޸� �Ҵ�
//        scrollPageValues = new float[transform.childCount];

//        //��ũ�� �Ǵ� ������ ������ �Ÿ�
//        valueDistance = 1f / (scrollPageValues.Length - 1f);

//        //��ũ�� �Ǵ� �������� �� value ��ġ ���� [0 <= value <= 1]
//        for (int i = 0; i < scrollPageValues.Length; ++ i )
//        {
//            scrollPageValues[i] = valueDistance * i;
//        }

//        //�ִ� �������� ��
//        maxPagePage = transform.childCount;
        
//    }
    

//    private void Start()
//    {
//        //���� ������ �� 0�� �������� �� �� �ֵ��� ����
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
