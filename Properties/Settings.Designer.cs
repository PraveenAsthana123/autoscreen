﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoScreenCapture.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int Interval {
            get {
                return ((int)(this["Interval"]));
            }
            set {
                this["Interval"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.1.7.5")]
        public string ApplicationVersion {
            get {
                return ((string)(this["ApplicationVersion"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.*")]
        public string ImageFormatFilter {
            get {
                return ((string)(this["ImageFormatFilter"]));
            }
            set {
                this["ImageFormatFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ScreenshotsDirectory {
            get {
                return ((string)(this["ScreenshotsDirectory"]));
            }
            set {
                this["ScreenshotsDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int SlideshowDelay {
            get {
                return ((int)(this["SlideshowDelay"]));
            }
            set {
                this["SlideshowDelay"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Auto Screen Capture")]
        public string ApplicationName {
            get {
                return ((string)(this["ApplicationName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int CaptureLimit {
            get {
                return ((int)(this["CaptureLimit"]));
            }
            set {
                this["CaptureLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CaptureLimitCheck {
            get {
                return ((bool)(this["CaptureLimitCheck"]));
            }
            set {
                this["CaptureLimitCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TakeInitialScreenshotCheck {
            get {
                return ((bool)(this["TakeInitialScreenshotCheck"]));
            }
            set {
                this["TakeInitialScreenshotCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int ImageResolutionRatio {
            get {
                return ((int)(this["ImageResolutionRatio"]));
            }
            set {
                this["ImageResolutionRatio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SlideSkipCheck {
            get {
                return ((bool)(this["SlideSkipCheck"]));
            }
            set {
                this["SlideSkipCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SlideSkip {
            get {
                return ((int)(this["SlideSkip"]));
            }
            set {
                this["SlideSkip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ImageFormatFilterIndex {
            get {
                return ((int)(this["ImageFormatFilterIndex"]));
            }
            set {
                this["ImageFormatFilterIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureStartAtCheck {
            get {
                return ((bool)(this["CaptureStartAtCheck"]));
            }
            set {
                this["CaptureStartAtCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureStopAtCheck {
            get {
                return ((bool)(this["CaptureStopAtCheck"]));
            }
            set {
                this["CaptureStopAtCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11/20/2013 08:00:00")]
        public global::System.DateTime CaptureStartAtValue {
            get {
                return ((global::System.DateTime)(this["CaptureStartAtValue"]));
            }
            set {
                this["CaptureStartAtValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11/20/2013 17:00:00")]
        public global::System.DateTime CaptureStopAtValue {
            get {
                return ((global::System.DateTime)(this["CaptureStopAtValue"]));
            }
            set {
                this["CaptureStopAtValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CaptureOnSaturdayCheck {
            get {
                return ((bool)(this["CaptureOnSaturdayCheck"]));
            }
            set {
                this["CaptureOnSaturdayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CaptureOnSundayCheck {
            get {
                return ((bool)(this["CaptureOnSundayCheck"]));
            }
            set {
                this["CaptureOnSundayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureOnMondayCheck {
            get {
                return ((bool)(this["CaptureOnMondayCheck"]));
            }
            set {
                this["CaptureOnMondayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureOnTuesdayCheck {
            get {
                return ((bool)(this["CaptureOnTuesdayCheck"]));
            }
            set {
                this["CaptureOnTuesdayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureOnWednesdayCheck {
            get {
                return ((bool)(this["CaptureOnWednesdayCheck"]));
            }
            set {
                this["CaptureOnWednesdayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureOnThursdayCheck {
            get {
                return ((bool)(this["CaptureOnThursdayCheck"]));
            }
            set {
                this["CaptureOnThursdayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureOnFridayCheck {
            get {
                return ((bool)(this["CaptureOnFridayCheck"]));
            }
            set {
                this["CaptureOnFridayCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CaptureOnTheseDaysCheck {
            get {
                return ((bool)(this["CaptureOnTheseDaysCheck"]));
            }
            set {
                this["CaptureOnTheseDaysCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JPEG")]
        public string ScheduleImageFormat {
            get {
                return ((string)(this["ScheduleImageFormat"]));
            }
            set {
                this["ScheduleImageFormat"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gavin Kendall")]
        public string ApplicationAuthor {
            get {
                return ((string)(this["ApplicationAuthor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen1X {
            get {
                return ((int)(this["Screen1X"]));
            }
            set {
                this["Screen1X"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen1Y {
            get {
                return ((int)(this["Screen1Y"]));
            }
            set {
                this["Screen1Y"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen1Width {
            get {
                return ((int)(this["Screen1Width"]));
            }
            set {
                this["Screen1Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen1Height {
            get {
                return ((int)(this["Screen1Height"]));
            }
            set {
                this["Screen1Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen2X {
            get {
                return ((int)(this["Screen2X"]));
            }
            set {
                this["Screen2X"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen2Y {
            get {
                return ((int)(this["Screen2Y"]));
            }
            set {
                this["Screen2Y"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen2Width {
            get {
                return ((int)(this["Screen2Width"]));
            }
            set {
                this["Screen2Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen2Height {
            get {
                return ((int)(this["Screen2Height"]));
            }
            set {
                this["Screen2Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen3X {
            get {
                return ((int)(this["Screen3X"]));
            }
            set {
                this["Screen3X"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen3Y {
            get {
                return ((int)(this["Screen3Y"]));
            }
            set {
                this["Screen3Y"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen3Width {
            get {
                return ((int)(this["Screen3Width"]));
            }
            set {
                this["Screen3Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen3Height {
            get {
                return ((int)(this["Screen3Height"]));
            }
            set {
                this["Screen3Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen4X {
            get {
                return ((int)(this["Screen4X"]));
            }
            set {
                this["Screen4X"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen4Y {
            get {
                return ((int)(this["Screen4Y"]));
            }
            set {
                this["Screen4Y"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen4Width {
            get {
                return ((int)(this["Screen4Width"]));
            }
            set {
                this["Screen4Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Screen4Height {
            get {
                return ((int)(this["Screen4Height"]));
            }
            set {
                this["Screen4Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowSystemTrayIcon {
            get {
                return ((bool)(this["ShowSystemTrayIcon"]));
            }
            set {
                this["ShowSystemTrayIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Passphrase {
            get {
                return ((string)(this["Passphrase"]));
            }
            set {
                this["Passphrase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LockScreenCaptureSession {
            get {
                return ((bool)(this["LockScreenCaptureSession"]));
            }
            set {
                this["LockScreenCaptureSession"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Screen 1")]
        public string Screen1Name {
            get {
                return ((string)(this["Screen1Name"]));
            }
            set {
                this["Screen1Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Screen 2")]
        public string Screen2Name {
            get {
                return ((string)(this["Screen2Name"]));
            }
            set {
                this["Screen2Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Screen 3")]
        public string Screen3Name {
            get {
                return ((string)(this["Screen3Name"]));
            }
            set {
                this["Screen3Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Screen 4")]
        public string Screen4Name {
            get {
                return ((string)(this["Screen4Name"]));
            }
            set {
                this["Screen4Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Macro {
            get {
                return ((string)(this["Macro"]));
            }
            set {
                this["Macro"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Active Window")]
        public string Screen5Name {
            get {
                return ((string)(this["Screen5Name"]));
            }
            set {
                this["Screen5Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public long JpegQualityLevel {
            get {
                return ((long)(this["JpegQualityLevel"]));
            }
            set {
                this["JpegQualityLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int DaysOldWhenRemoveSlides {
            get {
                return ((int)(this["DaysOldWhenRemoveSlides"]));
            }
            set {
                this["DaysOldWhenRemoveSlides"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureScreen1 {
            get {
                return ((bool)(this["CaptureScreen1"]));
            }
            set {
                this["CaptureScreen1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureScreen2 {
            get {
                return ((bool)(this["CaptureScreen2"]));
            }
            set {
                this["CaptureScreen2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureScreen3 {
            get {
                return ((bool)(this["CaptureScreen3"]));
            }
            set {
                this["CaptureScreen3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureScreen4 {
            get {
                return ((bool)(this["CaptureScreen4"]));
            }
            set {
                this["CaptureScreen4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureActiveWindow {
            get {
                return ((bool)(this["CaptureActiveWindow"]));
            }
            set {
                this["CaptureActiveWindow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoReset {
            get {
                return ((bool)(this["AutoReset"]));
            }
            set {
                this["AutoReset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StartWhenWindowsStartsCheck {
            get {
                return ((bool)(this["StartWhenWindowsStartsCheck"]));
            }
            set {
                this["StartWhenWindowsStartsCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Mouse {
            get {
                return ((bool)(this["Mouse"]));
            }
            set {
                this["Mouse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JPEG")]
        public string StartButtonImageFormat {
            get {
                return ((string)(this["StartButtonImageFormat"]));
            }
            set {
                this["StartButtonImageFormat"] = value;
            }
        }
    }
}
