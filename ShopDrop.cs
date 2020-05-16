using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameObject chosentower;
    private GameObject droppedtower;
    public MoneyBar moneyBar;
    public int price;
    public Canvas canvas;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //Debug.Log("OnDrag");
        
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (moneyBar.moneyValue - price >= 0)
        {
            //throw new System.NotImplementedException();
            //Debug.Log("OnEndDrag");
            Vector3 mousepos = Input.mousePosition;
            //Debug.Log(mousepos);
            mousepos.x = mousepos.x / 49.25f - 4;
            mousepos.y = mousepos.y / 39.4f - 5;
            Instantiate(chosentower, mousepos, Quaternion.Euler(0, 0, 0));
            moneyBar.subtractAmount(price);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //Debug.Log("OnPointerDown");
        //Instantiate(chosentower, Input.mousePosition);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
