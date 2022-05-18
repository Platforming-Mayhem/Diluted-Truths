using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    [SerializeField] private Material player;

    [SerializeField] private int frameRate = 12;

    [SerializeField] private Animator anim;

    private Vector2 originOffset;


    [SerializeField] private float offsetAmount;

    #region player dialogue flags

    public bool hasUSB1;
    public bool hasUSB2;
    public bool hasUSB3;

    #endregion

    private Rigidbody rb;

    public Transform[] spawns;

    public AudioClip footStep;

    AudioSource audioSource;

    private int numberOfFrames = 7;

    [SerializeField]
    private bool freezeForwardMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        offsetAmount = 0.0f;
        originOffset = player.mainTextureOffset;
        originOffset = new Vector2(0.02f, originOffset.y);
        StartCoroutine(WaitToPresentNextFrame());
        StartCoroutine(WaitToPlaySFX());
        if(PlayerPrefs.GetInt("changePos") == 1)
        {
            transform.position = spawns[PlayerPrefs.GetInt("index")].position;
            anim.SetTrigger("FadeIn");
        }
    }

    private void FixedUpdate()
    {
        if (freezeForwardMovement)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f) * movementSpeed + Vector3.up * rb.velocity.y;
        }
        else
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * movementSpeed + Vector3.up * rb.velocity.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void PlayFootstepSFX()
    {
        audioSource.pitch = Random.Range(1.0f, 3.0f);
        audioSource.PlayOneShot(footStep);
    }

    IEnumerator WaitToPresentNextFrame()
    {
        for (; ; )
        {
            yield return new WaitForSeconds((float)(1.0f / frameRate));
            if(offsetAmount >= (1.0f / 8.0f) * numberOfFrames)
            {
                offsetAmount = 0.0f;
                Debug.Log("Reset");
            }
            else
            {
                offsetAmount += (float)(1.0f / 8.0f);
            }
        }
    }

    IEnumerator WaitToPlaySFX()
    {
        for (; ; )
        {
            yield return new WaitForSeconds((float)(1.0f / frameRate * 6.0f));
            if (isWalking)
            {
                PlayFootstepSFX();
            }
        }
    }

    private bool isWalking = false;

    private void Move()
    {
        if(Input.GetAxis("Horizontal") > 0.0f)
        {
            originOffset = new Vector2(originOffset.x, 0.303f);
            numberOfFrames = 5;
            isWalking = true;
        }
        else if (Input.GetAxis("Horizontal") < 0.0f)
        {
            originOffset = new Vector2(originOffset.x, 0.044f);
            numberOfFrames = 5;
            isWalking = true;
        }
        else if (Input.GetAxis("Vertical") > 0.0f && !freezeForwardMovement)
        {
            originOffset = new Vector2(originOffset.x, 0.56f);
            numberOfFrames = 7;
            isWalking = true;
        }
        else if (Input.GetAxis("Vertical") < 0.0f && !freezeForwardMovement)
        {
            originOffset = new Vector2(originOffset.x, 0.784f);
            numberOfFrames = 7;
            isWalking = true;
        }
        else
        {
            offsetAmount = 0.0f;
            isWalking = false;
        }
        player.mainTextureOffset = originOffset + Vector2.right * offsetAmount;
    }

    private void OnDisable()
    {
        rb.velocity = Vector3.zero;
    }
}
