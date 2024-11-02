using UnityEngine;

public class InputReader : MonoBehaviour
{
    public bool GetInputSwing()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public bool GetInputPushingCatapult()
    {
        return Input.GetKeyDown(KeyCode.R);
    }

    public bool GetInputRechargeCatapult()
    {
        return Input.GetKeyDown(KeyCode.T);
    }

    public bool GetInputPushingSwing()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
