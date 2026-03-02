using UnityEngine;

public class left : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        transform.Translate(Vector3.left * 1f * Time.deltaTime);   
    }
}