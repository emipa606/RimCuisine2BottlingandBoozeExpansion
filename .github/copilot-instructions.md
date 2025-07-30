# Copilot Instructions for RimWorld Mod Development

## Mod Overview and Purpose

This mod enhances RimWorld gameplay by introducing the **RimCuisine 2: BB** extension, which focuses on expanding and diversifying drug policies within the game. The purpose of the mod is to add depth to the management of drug use, providing players with more options and strategies when it comes to the consumption and regulation of drugs in their colonies.

## Key Features and Systems

- **Expanded Drug Policies**: Introduces new drug policies that players can use to fine-tune the behavior of colonists concerning drug use. This includes new definitions and behaviors that integrate seamlessly into existing gameplay.

- **Integration with RimCuisine 2**: Works as an extension to the RimCuisine 2 mod, adding further complexity and choices related to food and drug consumption.

- **Customizable Options**: Offers customizable options that allow for greater player control over how drugs affect their colony, from addiction to mood boosts.

## Coding Patterns and Conventions

- **Consistency**: Follow consistent naming conventions and coding styles as established in the base game and modding community to improve readability and maintainability.
- **Namespace Organization**: Organize classes into proper namespaces to avoid conflicts with other mods. Use unique identifiers where necessary.
- **Static Classes for Definitions**: Utilize static classes like `RCBBDefOf` for defining custom game definitions, ensuring easy access and central management.

## XML Integration

Given that the XML parsing error didn't provide detailed insights, here are general practices to follow:

- **XML Structure**: Leveraging XML files, new drugs and their behaviors should be defined within the appropriate XML structure. These might include `ThingDefs`, `RecipeDefs`, and `DrugPolicyDefs`.

- **Patch Operations**: Use XPath PatchOperations to modify existing game XML where necessary rather than overriding whole files to ensure compatibility with other mods.

- **Localization**: Ensure that all added content is localizable by using `<key>` entries properly for each translated element.

## Harmony Patching

- **Harmony Setup**: Utilize `HarmonyPatches` for making runtime modifications to the game. Harmony allows selective method prefixing and postfixing without modifying the game's core DLLs.
  
- **Safeguard Patches**: Implement checks and logging within patches to handle possible conflicts or errors gracefully. Ensure to test patches thoroughly to avoid unexpected behaviors.

- **Non-Invasive Modding**: Focus on non-destructive hooking techniques to allow other mods to coexist without interference.

## Suggestions for Copilot

- **Autocomplete Suggestions**: Use suggested code completions for routine tasks such as method stubs, XML formatting, and patch templates to speed up coding.
  
- **Documentation Integration**: Encourage Copilot to suggest summaries and documentation for methods to improve code readability and team collaborations.

- **Testing Frameworks**: Request test case generation or test frameworks setup from Copilot, as automated testing significantly aids in ensuring the stability of mod functionalities.

By following these guidelines and best practices, developers can leverage GitHub Copilot effectively, maintain high-quality, and ensure compatibility with other RimWorld mods.
