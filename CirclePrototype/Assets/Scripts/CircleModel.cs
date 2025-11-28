using UnityEngine;
using System.Collections;

public class CircleModel : MonoBehaviour
{
    [SerializeField] private int max = 10;
    int timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = Random.Range(1, max+1);
        StartCoroutine(DestroyCircle(timer));
    }

    IEnumerator DestroyCircle(int timer)
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }
}
