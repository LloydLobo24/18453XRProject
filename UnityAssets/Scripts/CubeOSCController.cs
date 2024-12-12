using UnityEngine;
using extOSC;

public class CubeOSCController : MonoBehaviour
{
    public OSCTransmitter oscTransmitter;  
    private bool isBButtonToggled;

    void Update()
    {
        if (oscTransmitter == null) return;

        // Get the cube's position and rotation
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Create an OSC message
        var message = new OSCMessage("/cube");
        message.AddValue(OSCValue.Float(position.x));
        message.AddValue(OSCValue.Float(position.y));
        message.AddValue(OSCValue.Float(position.z));
        message.AddValue(OSCValue.Float(rotation.eulerAngles.x)); // Y-axis rotation
        //message.AddValue(OSCValue.Bool(isBButtonToggled)); // Add B button flag
        message.AddValue(OSCValue.Float(rotation.eulerAngles.y));
        message.AddValue(OSCValue.Float(rotation.eulerAngles.z));
        // Send the message
        oscTransmitter.Send(message);
    }
}
