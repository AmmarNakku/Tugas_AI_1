using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        transform.Translate(Vector3.right * 1f * Time.deltaTime);   
    }
}