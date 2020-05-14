﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BPCClassLibrary
{
    public class Truckdriver
    {
        #region Instance fields

        private int _id;
        private string _telephoneNo;
        private string _eMail;
        #endregion

        #region Constructors

        public Truckdriver()
        {

        }
        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string TelephoneNo
        {
            get => _telephoneNo;
            set => _telephoneNo = value;
        }

        public string EMail
        {
            get => _eMail;
            set => _eMail = value;
        }
        #endregion
    }
}
