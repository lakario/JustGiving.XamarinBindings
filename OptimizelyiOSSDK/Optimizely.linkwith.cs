using System;
using ObjCRuntime;

[assembly: LinkWith ("Optimizely.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, 
    SmartLink = false, ForceLoad = true, 
    Frameworks = "AudioToolbox CFNetwork MobileCoreServices Security SystemConfiguration",
    LinkerFlags = "-licucore")]
