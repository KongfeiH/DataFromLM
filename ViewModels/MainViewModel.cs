using GalaSoft.MvvmLight;
using Leap;
using LeapMotionAngel.Global;
using LeapMotionAngel.Models;

namespace LeapMotionAngel.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            //if (IsInDesignMode)
            //{
            //    // Code runs in Blend --> create design time data.
            //}
            //else
            //{
            //    // Code runs "for real"
            //}
            mainModel = new MainModel();
            using (Leap.IController controller = new Leap.Controller())
            {
                controller.SetPolicy(Leap.Controller.PolicyFlag.POLICY_ALLOW_PAUSE_RESUME);

                // Set up our listener:
                ListenerClass listener = new ListenerClass();
              
                controller.Connect += listener.OnServiceConnect;
                controller.Disconnect += listener.OnServiceDisconnect;
                controller.FrameReady += OnFrame;
                controller.Device += OnConnect;
                controller.DeviceLost += OnDisconnect;
                controller.DeviceFailure += listener.OnDeviceFailure;
                controller.LogMessage += listener.OnLogMessage;
             
            }
         
        }


        private void OnConnect(object sender, DeviceEventArgs args)
        {
            mainModel.Status = "Connect";
        }
        private void OnDisconnect(object sender, DeviceEventArgs args)
        {
            mainModel.Status = "Disconnect";
        }

        private void OnFrame(object sender, FrameEventArgs args)
        {
            // Get the most recent frame and report some basic information
            Frame frame = args.frame;

            //Console.WriteLine(
            //  "Frame id: {0}, timestamp: {1}, hands: {2}",
            //  frame.Id, frame.Timestamp, frame.Hands.Count
            //);

            //foreach (Hand hand in frame.Hands)
            //{
            if (frame.Hands.Count !=0)
            { 
                Hand hand = frame.Hands[0];
            //    //Console.WriteLine("  Hand id: {0}, palm position: {1}, fingers: {2}",
            //    //  hand.Id, hand.PalmPosition, hand.Fingers.Count);
            //    // Get the hand's normal vector and direction
            //    Vector normal = hand.PalmNormal;
            //    Vector direction = hand.Direction;

            //    // Calculate the hand's pitch, roll, and yaw angles
            //    //Console.WriteLine(
            //    //  "  Hand pitch: {0} degrees, roll: {1} degrees, yaw: {2} degrees",
            //    //  direction.Pitch * 180.0f / (float)Math.PI,
            //    //  normal.Roll * 180.0f / (float)Math.PI,
            //    //  direction.Yaw * 180.0f / (float)Math.PI
            //    //);

            //    // Get the Arm bone
            ////    Arm arm = hand.Arm;
            ////    Console.WriteLine(
            ////      "  Arm direction: {0}, wrist position: {1}, elbow position: {2}",
            ////      arm.Direction, arm.WristPosition, arm.ElbowPosition
            ////    );

            //    // Get fingers
            //    foreach (Finger finger in hand.Fingers)
            //    {
           
            //        Console.WriteLine(
            //          "    Finger id: {0}, {1}, length: {2}mm, width: {3}mm",
            //          finger.Id,
            //          finger.Type.ToString(),
            //          finger.Length,
            //          finger.Width
            //        );

            //        // Get finger bones
                    Bone bone0,bone1, bone2, bone3;
                //        for (int b = 0; b < 4; b++)
                //        {
                for (int i = 0; i < 5; i++)
                {
                    bone0 = hand.Fingers[i].Bone((Bone.BoneType)0);
                    bone1 = hand.Fingers[i].Bone((Bone.BoneType)1);
                    bone2 = hand.Fingers[i].Bone((Bone.BoneType)2);
                    bone3 = hand.Fingers[i].Bone((Bone.BoneType)3);
                    double angle = ((bone0.Direction.x) * (bone1.Direction.x) +
                    (bone0.Direction.y) * (bone1.Direction.y) +
                    (bone0.Direction.z) * (bone1.Direction.z));

                    double angle1 = ((bone1.Direction.x) * (bone2.Direction.x) +
                    (bone1.Direction.y) * (bone2.Direction.y) +
                    (bone1.Direction.z) * (bone2.Direction.z));

                    double angle2 = ((bone3.Direction.x) * (bone2.Direction.x) +
                    (bone3.Direction.y) * (bone2.Direction.y) +
                    (bone3.Direction.z) * (bone2.Direction.z));
                    switch (i)
                    {

                        case 0:
                            mainModel.FirFingerBoneFirAngel = System.Math.Round(180 - ((System.Math.Acos(angle)) / System.Math.PI) * 180).ToString();
                            mainModel.FirFingerBoneSencondAngel = System.Math.Round(180 - ((System.Math.Acos(angle1)) / System.Math.PI) * 180).ToString();
                            mainModel.FirFingerBoneThirdAngel = System.Math.Round(180 - ((System.Math.Acos(angle2)) / System.Math.PI) * 180).ToString(); break;
                        case 1: mainModel.FingerBoneFirAngel = System.Math.Round(180 - ((System.Math.Acos(angle)) / System.Math.PI) * 180).ToString();
                        mainModel.FingerBoneSencondAngel = System.Math.Round(180 - ((System.Math.Acos(angle1)) / System.Math.PI) * 180).ToString();
                        mainModel.FingerBoneThirdAngel = System.Math.Round(180 - ((System.Math.Acos(angle2)) / System.Math.PI) * 180).ToString();break;
                        case 2:
                            mainModel.SecondFingerBoneFirAngel = System.Math.Round(180 - ((System.Math.Acos(angle)) / System.Math.PI) * 180).ToString();
                            mainModel.SecondFingerBoneSencondAngel = System.Math.Round(180 - ((System.Math.Acos(angle1)) / System.Math.PI) * 180).ToString();
                            mainModel.SencondFingerBoneThirdAngel = System.Math.Round(180 - ((System.Math.Acos(angle2)) / System.Math.PI) * 180).ToString(); break;
                        case 3:
                            mainModel.ThirdFirFingerBoneFirAngel = System.Math.Round(180 - ((System.Math.Acos(angle)) / System.Math.PI) * 180).ToString();
                            mainModel.ThirdFingerBoneSencondAngel = System.Math.Round(180 - ((System.Math.Acos(angle1)) / System.Math.PI) * 180).ToString();
                            mainModel.ThirdFingerBoneThirdAngel = System.Math.Round(180 - ((System.Math.Acos(angle2)) / System.Math.PI) * 180).ToString(); break;
                        case 4:
                            mainModel.LastFingerBoneFirAngel = System.Math.Round(180 - ((System.Math.Acos(angle)) / System.Math.PI) * 180).ToString();
                            mainModel.LastFingerBoneSencondAngel = System.Math.Round(180 - ((System.Math.Acos(angle1)) / System.Math.PI) * 180).ToString();
                            mainModel.LastFingerBoneThirdAngel = System.Math.Round(180 - ((System.Math.Acos(angle2)) / System.Math.PI) * 180).ToString(); break;
                    }
                }
          
              

                //            bone = finger.Bone((Bone.BoneType)b);
                //            Console.WriteLine(
                //              "      Bone: {0}, start: {1}, end: {2}, direction: {3}",
                //              bone.Type, bone.PrevJoint, bone.NextJoint, bone.Direction
                //            );
                //        }
                //    }
                //}

                //if (frame.Hands.Count != 0)
                //{
                //    Console.WriteLine("");
                //}
            }
        }














        #region ÊôÐÔ

        private MainModel mainModel;

        public MainModel MainModel
        {
            get { return mainModel; }
            set { mainModel = value; RaisePropertyChanged(() => MainModel); }
        }
        #endregion

    }
}