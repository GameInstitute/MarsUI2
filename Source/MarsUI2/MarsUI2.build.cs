// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class MarsUI2 : ModuleRules
	{
		public MarsUI2(ReadOnlyTargetRules Target) : base(Target)
		{
            PrivatePCHHeaderFile = "Private/MarsUI2PrivatePCH.h";
			bPrecompile = true;
			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
				    "CoreUObject",
                    "Engine",
                    "BrowserCore",
                    "Slate",
                    "SlateCore",
					"UMG"
				}
			);
		}
	}
}
