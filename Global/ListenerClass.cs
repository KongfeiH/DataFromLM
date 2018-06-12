using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;
namespace LeapMotionAngel.Global
{
    class ListenerClass
    {
        
 

         



            public void OnFrame(object sender, FrameEventArgs args)
            {
                // Get the most recent frame and report some basic information
                Frame frame = args.frame;

                Console.WriteLine(
                  "Frame id: {0}, timestamp: {1}, hands: {2}",
                  frame.Id, frame.Timestamp, frame.Hands.Count
                );

                foreach (Hand hand in frame.Hands)
                {
               
                    Console.WriteLine("  Hand id: {0}, palm position: {1}, fingers: {2}",
                      hand.Id, hand.PalmPosition, hand.Fingers.Count);
                    // Get the hand's normal vector and direction
                    Vector normal = hand.PalmNormal;
                    Vector direction = hand.Direction;

                    // Calculate the hand's pitch, roll, and yaw angles
                    Console.WriteLine(
                      "  Hand pitch: {0} degrees, roll: {1} degrees, yaw: {2} degrees",
                      direction.Pitch * 180.0f / (float)Math.PI,
                      normal.Roll * 180.0f / (float)Math.PI,
                      direction.Yaw * 180.0f / (float)Math.PI
                    );

                    // Get the Arm bone
                    Arm arm = hand.Arm;
                    Console.WriteLine(
                      "  Arm direction: {0}, wrist position: {1}, elbow position: {2}",
                      arm.Direction, arm.WristPosition, arm.ElbowPosition
                    );

                    // Get fingers
                    foreach (Finger finger in hand.Fingers)
                    {
                        Console.WriteLine(
                          "    Finger id: {0}, {1}, length: {2}mm, width: {3}mm",
                          finger.Id,
                          finger.Type.ToString(),
                          finger.Length,
                          finger.Width
                        );

                        // Get finger bones
                        Bone bone;
                        for (int b = 0; b < 4; b++)
                        {
                            bone = finger.Bone((Bone.BoneType)b);
                            Console.WriteLine(
                              "      Bone: {0}, start: {1}, end: {2}, direction: {3}",
                              bone.Type, bone.PrevJoint, bone.NextJoint, bone.Direction
                            );
                        }
                    }
                }

                if (frame.Hands.Count != 0)
                {
                    Console.WriteLine("");
                }
            }

            public void OnServiceConnect(object sender, ConnectionEventArgs args)
            {
                Console.WriteLine("Service Connected");
            }

            public void OnServiceDisconnect(object sender, ConnectionLostEventArgs args)
            {
                Console.WriteLine("Service Disconnected");
            }

            public void OnServiceChange(Controller controller)
            {
                Console.WriteLine("Service Changed");
            }

            public void OnDeviceFailure(object sender, DeviceFailureEventArgs args)
            {
                Console.WriteLine("Device Error");
                Console.WriteLine("  PNP ID:" + args.DeviceSerialNumber);
                Console.WriteLine("  Failure message:" + args.ErrorMessage);
            }

            public void OnLogMessage(object sender, LogEventArgs args)
            {
                switch (args.severity)
                {
                    case Leap.MessageSeverity.MESSAGE_CRITICAL:
                        Console.WriteLine("[Critical]");
                        break;
                    case Leap.MessageSeverity.MESSAGE_WARNING:
                        Console.WriteLine("[Warning]");
                        break;
                    case Leap.MessageSeverity.MESSAGE_INFORMATION:
                        Console.WriteLine("[Info]");
                        break;
                    case Leap.MessageSeverity.MESSAGE_UNKNOWN:
                        Console.WriteLine("[Unknown]");
                        break;
                }
                Console.WriteLine("[{0}] {1}", args.timestamp, args.message);
            }
        
    }
}
