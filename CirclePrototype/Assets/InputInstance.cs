using UnityEngine;

public class InputInstance : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) Instantiate(prefab, input, Quaternion.identity);
    }
}
