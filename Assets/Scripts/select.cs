using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class select : MonoBehaviour, IPointerClickHandler
{
    //  타 스크립트에서 chatBox 끄기, Panel 켜기하며 호출됨
    mainButton mClass = new mainButton();
    public Queue<int> selectQ;


    void Start()
    {
        selectQ = mClass.selectQ;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if(this.tag == "select1")
        {
            selectQ.Enqueue(1);
        }
        else if (this.tag == "select2")
        {
            selectQ.Enqueue(2);
        }

        Debug.Log(selectQ.Dequeue());
    }

}
