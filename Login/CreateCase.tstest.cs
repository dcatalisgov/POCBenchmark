using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.DesktopAutomation;

namespace POCBenchmark
{
    public class CreateCase : BaseWebAiiTest
    {
        #region [ Dynamic DesktopApplications Reference ]

        private DesktopApplications desktopApplications;

        /// <summary>
        /// Gets the DesktopApplications object that has references
        /// to all the elements and windows in this project.
        /// </summary>
        public DesktopApplications DesktopApplications
        {
            get
            {
                if (this.desktopApplications == null)
                {
                    this.desktopApplications = new DesktopApplications(Manager.Current);
                }
                return this.desktopApplications;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"LeftClick on ButtonCase")]
        public void CreateCase_CodedStep()
        {
            // LeftClick on ButtonCase
            DesktopApplications.CourtWin.Benchmark_Principal_Page.ButtonCase.User.Click(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 20, 10, ArtOfTest.Common.OffsetReference.TopLeftCorner, ArtOfTest.Common.ActionPointUnitType.Pixel, ((System.Windows.Forms.Keys)(0)));
            
        }
    }
}
