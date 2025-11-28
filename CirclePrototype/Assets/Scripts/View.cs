using UnityEngine;
using System;

public class View : MonoBehaviour
{
    public event Action<Vector2> OnScreenClicked;
    void Start()
    {
        Camera.main.backgroundColor = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input;
        input = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        OnScreenClicked?.Invoke(input);
    }
}
