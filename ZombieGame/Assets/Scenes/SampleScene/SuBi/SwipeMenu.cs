//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class SwipeMenu : MonoBehaviour
//{
//    public GameObject scrollbar;
//    float scroll_pos = 0;
//    float[] pos;
//    //Use this for initialization
    
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        pos = new float[transform.childCount];
//        float distance = 1f / (pos.Length - 1f); 
//        for (int i = 0; i < pos.Length; i++) 
//        {
//            pos [i] = distance * if;
//        }
//        if (Input.GetMouseButton(0))
//        {
//            scroll_pos = scrollbar.GetComponent<scrollbar>().value;
//        }
//        else
//        {
//            for(int i = 0; i < pos.Length; i++)
//            {
//                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos [i] - (distance / 2))
//                {
//                    scrollbar.GetComponent<scrollbar>().value = Mathf.Lerp (scrollbar.GetComponent<Scrollbar> ().value, pos[i],0.1f)
//                }
//            }
//        }
//    }
//}
