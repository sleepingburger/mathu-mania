using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderScript : MonoBehaviour, IPointerUpHandler
{
    // Start is called before the first frame update

    [SerializeField]
    public Slider aslider;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    

    public void OnPointerUp(PointerEventData eventData)
    {
        aslider.value = 0f;
    }

}
