using UnityEngine;
using UnityEngine.Audio;


public class PlayerMovement : MonoBehaviour
{
    private AudioSource audioSource;
    public float moveSpeed = 5f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if ((moveX != 0 || moveZ != 0) && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}