# GitHub Copilot Instructions for RimCuisine 2: Bottling and Booze Expansion (Continued)

This document provides guidelines for using GitHub Copilot in the development of the RimCuisine 2: Bottling and Booze Expansion mod for RimWorld. Copilot can be a powerful tool when used effectively, but it's important to understand the coding patterns and conventions used in this mod to ensure that the generated code is both functional and compliant with the mod's standards.

## Mod Overview and Purpose

**RimCuisine 2: Bottling and Booze Expansion (Continued)** is an update of the Crustypeanuts mod, focusing on enhancing the beverage and alcohol system in RimWorld. The mod introduces various new alcohol types, non-alcoholic beverages, and related brewing and distilling systems. It also updates the mod to use the Universal Fermenter (UF) and Processor Framework, ensuring compatibility with the latest RimWorld updates.

## Key Features and Systems

### 1. New Beverage Types
- **Alcoholic Drinks**: Vodka, Tequila, Ale, Stout, Wine, Mead, and others.
- **Non-Alcoholic Drinks**: Iced Tea, Hot Cocoa, Energy Drinks, Fruit Soda, etc.

### 2. Fermentation Process
- **Fermented Drinks**: Similar to beer, these drinks are processed at a brewery and then fermented in casks.
- **Distilled Drinks**: Made by distilling raw ingredients in a fermenting barrel and then at a distillery.

### 3. Ambrosia Nectar
- A special fermented drink made from Ambrosia, requiring specialized casks and a long fermentation period.
- Causes temporary addiction and drunken effects but no permanent negative health effects.

### 4. Electric Brewery
- An upgraded brewery that requires power and components, working faster than the standard brewery.

### 5. Compatibility Patches
- Patches for compatibility with other mods like VFE and Misc. Bees'n'Honey via The Manual.

## Coding Patterns and Conventions

### 1. Code Organization
- **C# Files**:
  - **HarmonyPatches.cs**: Contains Harmony patches for modifying vanilla behavior.
  - **RCBBDefOf.cs**: Contains `DefOf` classes for accessing mod-specific definitions.
  - **Scenario_PostGameStart_Patch.cs**: Contains patches for scenario-related events.

- **XML Files**: Definitions for various mod elements like `ThingDef`, `HediffDef`, `NeedDef`, etc.

### 2. Naming Conventions
- **Classes**: PascalCase (e.g., `HarmonyPatches`)
- **Methods**: PascalCase (e.g., `Postfix`)
- **Variables**: camelCase (e.g., `fermentingProgress`)

### 3. Commenting
- Use XML-style comments for methods and classes to provide documentation.
- Comment on complex logic to ensure clarity for other developers.

### 4. Error Handling
- Implement try-catch blocks for critical operations to handle unexpected errors gracefully.

## XML Integration

### 1. Def Files
- **Structure**: Each XML file should define a specific type of mod element, such as a `ThingDef` or `HediffDef`.
- **Attributes**: Ensure all required attributes are present and correctly formatted.
- **Consistency**: Maintain consistency in attribute names and values across all def files.

### 2. ModDefs
- **DefOf Classes**: Use `DefOf` classes to easily access mod-specific definitions.
- **Loading**: Ensure that all mod definitions are loaded correctly during the game initialization phase.

## Harmony Patching

### 1. Basic Structure
- **Prefix/Postfix**: Use `Prefix` and `Postfix` methods to modify method behavior before and after execution.
- **Transpilers**: Use transpilers for more complex modifications that require bytecode manipulation.

### 2. Target Methods
- **Identify Targets**: Carefully identify the target methods to patch, ensuring that the patch does not interfere with vanilla or other mod behavior.
- **Backup**: Always keep a backup of the original method before applying patches.

### 3. Testing
- **Thorough Testing**: After applying patches, thoroughly test the mod to ensure that the patched methods work as expected without breaking other functionalities.

## Suggestions for Copilot

### 1. Use with Caution
- Copilot can generate code quickly, but it's essential to review and test the generated code to ensure it meets the mod's standards and requirements.

### 2. Focus on Specific Tasks
- Use Copilot for specific tasks like generating XML def files or simple Harmony patches. For more complex logic, it's better to write the code manually.

### 3. Provide Context
- When using Copilot, provide as much context as possible, such as the specific mod element or behavior you want to implement. This helps Copilot generate more relevant and accurate code.

### 4. Review Generated Code
- Always review and test the generated code for correctness, performance, and compatibility with other mod elements.

By following these guidelines, you can effectively use GitHub Copilot to enhance the development of the RimCuisine 2: Bottling and Booze Expansion mod while maintaining code quality and mod compatibility.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

