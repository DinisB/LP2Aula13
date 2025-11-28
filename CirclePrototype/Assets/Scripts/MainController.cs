using UnityEngine;
using System;

public class MainController : MonoBehaviour
{
    private GameObject circle;
    private View view;
    void Awake()
    {
        circle = Resources.Load<GameObject>("Prefabs/Circle");
        view = GetComponent<View>();
    }

    private void OnEnable()
    {
        view.OnScreenClicked += SpawnCircle;
    }

    private void OnDisable()
    {
        view.OnScreenClicked -= SpawnCircle;
    }

    private void SpawnCircle(Vector2 pos)
    {
        Instantiate(circle, pos, Quaternion.identity);
    }
}
