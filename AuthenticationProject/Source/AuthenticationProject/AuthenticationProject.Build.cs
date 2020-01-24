using UnrealBuildTool;

public class AuthenticationProject : ModuleRules
{
	public AuthenticationProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "FirebaseAuthentication" });
		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
