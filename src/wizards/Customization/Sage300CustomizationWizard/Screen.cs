﻿// The MIT License (MIT) 
// Copyright (c) 1994-2017 The Sage Group plc or its licensors.  All rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in 
// the Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Sage.CA.SBS.ERP.Sage300.CustomizationWizard
{
    /// <summary> Class to hold information for screen </summary>
    public class Screen
    {
        #region Public Properties
        /// <summary> Module Id </summary>
        public ModuleType ModuleId { get; set; }

        /// <summary> Category </summary>
        public string Category { get; set; }

        /// <summary> Target Screen Name </summary>
        public string TargetScreen { get; set; }

        /// <summary> Screen Description </summary>
        public string Description { get; set; }

        /// <summary> Screen Name (Customized) </summary>
        public string ScreenName { get; set; }

        /// <summary> Controls Configuration - XML Settings filename </summary>
        public string ControlsConfiguration { get; set; }

        /// <summary> Controls Behavior - Javascript filename </summary>
        public string ControlsBehavior { get; set; }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
