using UnityEngine;

public class Goomba : MonoBehaviour
{
    public float speed = 4f;
    public float changeInterval = 2f;
    private float timer = 0f;
    private bool movingleft = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // update timer and flip direction when interval elapses
        timer += Time.deltaTime;
        if (timer >= changeInterval)
        {
            movingleft = !movingleft;
            timer = 0f;
        }

        // move left or right depending on movingleft
        Vector3 direction = movingleft ? Vector3.left : Vector3.right;
        transform.position += direction * speed * Time.deltaTime;
    }
}
