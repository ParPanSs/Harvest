using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer _sr;
    public Sprite pressedButton;
    public Sprite defaultButton;
    
    public KeyCode keyToPress; 
    
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            _sr.sprite = pressedButton;
        }
        if(Input.GetKeyUp(keyToPress))
        {
            _sr.sprite = defaultButton;
        }
    }
}
