using UnrealBuildTool;

public class AnalyticsProject : ModuleRules
{
	public AnalyticsProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "FirebaseAnalytics" });
		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
