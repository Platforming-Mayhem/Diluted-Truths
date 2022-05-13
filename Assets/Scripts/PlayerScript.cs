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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        offsetAmount = 0.0f;
        originOffset = player.mainTextureOffset;
        originOffset = new Vector2(0.0375f, originOffset.y);
        StartCoroutine(WaitToPresentNextFrame());
        if(PlayerPrefs.GetInt("changePos") == 1)
        {
            transform.position = spawns[PlayerPrefs.GetInt("index")].position;
            anim.SetTrigger("FadeIn");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    IEnumerator WaitToPresentNextFrame()
    {
        for (; ; )
        {
            yield return new WaitForSeconds((float)(1.0f / frameRate));
            offsetAmount += (float)(1.0f / 13.0f);
        }
    }

    private void Move()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * movementSpeed;
        if(Input.GetAxis("Horizontal") > 0.0f)
        {
            originOffset = new Vector2(originOffset.x, 0.294f);
        }
        else if (Input.GetAxis("Horizontal") < 0.0f)
        {
            originOffset = new Vector2(originOffset.x, 0.044f);
        }
        else if (Input.GetAxis("Vertical") > 0.0f)
        {
            originOffset = new Vector2(originOffset.x, 0.544f);
        }
        else if (Input.GetAxis("Vertical") < 0.0f)
        {
            originOffset = new Vector2(originOffset.x, 0.544f);
        }
        else
        {
            offsetAmount = 0.0f;
        }
        player.mainTextureOffset = originOffset + Vector2.right * offsetAmount;
    }
}
