using ObjCRuntime;
using ExternalAccessory;

[assembly: LinkWith ("libepos2.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator64 | LinkTarget.Simulator | LinkTarget.ArmV6 , SmartLink = true, ForceLoad = true, LinkerFlags = "-framework ExternalAccessory -lz -lxml2.2")]
