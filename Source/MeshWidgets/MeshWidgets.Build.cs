using UnrealBuildTool;

public class MeshWidgets : ModuleRules
{
	public MeshWidgets(ReadOnlyTargetRules Target) : base(Target)
	{
        bEnforceIWYU = true;

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        MinFilesUsingPrecompiledHeaderOverride = 1;
        bFasterWithoutUnity = true;

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                
            }
        );

        if (Target.Type == TargetType.Editor)
        {
            PublicDependencyModuleNames.AddRange(
                new string[] {
                    "UnrealEd",
                    "EditorWidgets"
                }
            );
        }
	}
}
