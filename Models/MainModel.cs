using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionAngel.Models
{
  public  class MainModel : ObservableObject
    {
        private string status = "Please Insert LeapMotion";

        public string Status
        {
            get { return status; }
            set { status = value; RaisePropertyChanged(() => Status); }
        }

        #region 大拇指
        private string fingerBoneFirAngel = "0";

        public string FingerBoneFirAngel
        {
            get { return fingerBoneFirAngel; }
            set { fingerBoneFirAngel = value; RaisePropertyChanged(() => FingerBoneFirAngel); }
        }

        private string fingerBoneSencondAngel = "0";

        public string FingerBoneSencondAngel
        {
            get { return fingerBoneSencondAngel; }
            set { fingerBoneSencondAngel = value; RaisePropertyChanged(() => FingerBoneSencondAngel); }
        }

        private string fingerBoneThirdAngel = "0";

        public string FingerBoneThirdAngel
        {
            get { return fingerBoneThirdAngel; }
            set { fingerBoneThirdAngel = value; RaisePropertyChanged(() => FingerBoneThirdAngel); }
        }

        #endregion

        #region 食指
        private string firFingerBoneFirAngel = "0";

        public string   FirFingerBoneFirAngel
        {
            get { return firFingerBoneFirAngel; }
            set { firFingerBoneFirAngel = value; RaisePropertyChanged(() => FirFingerBoneFirAngel); }
        }

        private string firFingerBoneSencondAngel = "0";

        public string FirFingerBoneSencondAngel
        {
            get { return firFingerBoneSencondAngel; }
            set { firFingerBoneSencondAngel = value; RaisePropertyChanged(() => FirFingerBoneSencondAngel); }
        }

        private string firFingerBoneThirdAngel = "0";

        public string FirFingerBoneThirdAngel
        {
            get { return firFingerBoneThirdAngel; }
            set { firFingerBoneThirdAngel = value; RaisePropertyChanged(() => FirFingerBoneThirdAngel); }
        }
        #endregion
        #region 中指
        private string secondFingerBoneFirAngel = "0";

        public string SecondFingerBoneFirAngel
        {
            get { return secondFingerBoneFirAngel; }
            set { secondFingerBoneFirAngel = value; RaisePropertyChanged(() => SecondFingerBoneFirAngel); }
        }

        private string secondFingerBoneSencondAngel = "0";

        public string SecondFingerBoneSencondAngel
        {
            get { return secondFingerBoneSencondAngel; }
            set { secondFingerBoneSencondAngel = value; RaisePropertyChanged(() => SecondFingerBoneSencondAngel); }
        }

        private string sencondFingerBoneThirdAngel = "0";

        public string SencondFingerBoneThirdAngel
        {
            get { return sencondFingerBoneThirdAngel; }
            set { sencondFingerBoneThirdAngel = value; RaisePropertyChanged(() => SencondFingerBoneThirdAngel); }
        }

        #endregion


        #region 无名指
        private string thirdFingerBoneFirAngel = "0";

        public string ThirdFirFingerBoneFirAngel
        {
            get { return thirdFingerBoneFirAngel; }
            set { thirdFingerBoneFirAngel = value; RaisePropertyChanged(() => ThirdFirFingerBoneFirAngel); }
        }

        private string thirdFingerBoneSencondAngel = "0";

        public string ThirdFingerBoneSencondAngel
        {
            get { return thirdFingerBoneSencondAngel; }
            set { thirdFingerBoneSencondAngel = value; RaisePropertyChanged(() => ThirdFingerBoneSencondAngel); }
        }

        private string thirdFingerBoneThirdAngel = "0";

        public string ThirdFingerBoneThirdAngel
        {
            get { return thirdFingerBoneThirdAngel; }
            set { thirdFingerBoneThirdAngel = value; RaisePropertyChanged(() => ThirdFingerBoneThirdAngel); }
        }
        #endregion



        #region 小母指
        private string lastFingerBoneFirAngel = "0";

        public string LastFingerBoneFirAngel
        {
            get { return lastFingerBoneFirAngel; }
            set { lastFingerBoneFirAngel = value; RaisePropertyChanged(() => LastFingerBoneFirAngel); }
        }

        private string lastFingerBoneSencondAngel = "0";

        public string LastFingerBoneSencondAngel
        {
            get { return lastFingerBoneSencondAngel; }
            set { lastFingerBoneSencondAngel = value; RaisePropertyChanged(() => LastFingerBoneSencondAngel); }
        }

        private string lastFingerBoneThirdAngel = "0";

        public string LastFingerBoneThirdAngel
        {
            get { return lastFingerBoneThirdAngel; }
            set { lastFingerBoneThirdAngel = value; RaisePropertyChanged(() => LastFingerBoneThirdAngel); }
        }
        #endregion
    }
}
