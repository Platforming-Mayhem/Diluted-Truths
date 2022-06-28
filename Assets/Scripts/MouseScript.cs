using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class MouseScript : MonoBehaviour
{
    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int X, int Y);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
    // Start is called before the first frame update
    void Start()
    {
        gamepadInput = new Vector2(1920.0f / 2.0f, 1080.0f / 2.0f);
        Cursor.visible = true;
    }

    public Vector2 gamepadInput;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetJoystickNames().Length > 0)
        {
            gamepadInput += new Vector2(Input.GetAxis("Horizontal"), -Input.GetAxis("Vertical")) * 10.0f;
            gamepadInput.x = Mathf.Clamp(gamepadInput.x, 0.0f, 1920.0f);
            gamepadInput.y = Mathf.Clamp(gamepadInput.y, 0.0f, 1080.0f);
            SetCursorPos((int)gamepadInput.x, (int)gamepadInput.y);
            if (Input.GetButtonDown("Jump"))
            {
                mouse_event(0x02, (uint)gamepadInput.x, (uint)gamepadInput.y, 0, 0);
            }
            else if (Input.GetButtonUp("Jump"))
            {
                mouse_event(0x04, (uint)gamepadInput.x, (uint)gamepadInput.y, 0, 0);
            }
        }
    }
}
