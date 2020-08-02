// Open World Bakery free additions
// Copyright 2020 Dmitry Grivov, g@primitive.game, all rights reserved

using UnrealBuildTool;

public class OWB_EasyVox_Demo : ModuleRules
{
	public OWB_EasyVox_Demo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "OWBEasyVoxel", "OpenWorldBakery" });
	}
}
