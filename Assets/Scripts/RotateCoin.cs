using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotateSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // Start logic here
    }

    private void Update() => transform.Rotate(3f, rotateSpeed * Time.deltaTime, 3f);// Update logic here
}


