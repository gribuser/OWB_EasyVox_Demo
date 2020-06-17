// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OWB_EasyVox_Demo : ModuleRules
{
	public OWB_EasyVox_Demo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
