﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Esri.ArcGISRuntime.Toolkit.SampleApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.Toolkit.UI.Controls.Compass compass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.UI.Controls.MapView mapView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.Toolkit.UI.Controls.PopupViewer popupViewer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.Toolkit.UI.Controls.ScaleLine scaleLine { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (compass != null) {
                compass.Dispose ();
                compass = null;
            }

            if (mapView != null) {
                mapView.Dispose ();
                mapView = null;
            }

            if (popupViewer != null) {
                popupViewer.Dispose ();
                popupViewer = null;
            }

            if (scaleLine != null) {
                scaleLine.Dispose ();
                scaleLine = null;
            }
        }
    }
}