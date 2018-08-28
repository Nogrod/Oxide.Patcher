uMod Patcher
============

## Patching

 1. Navigate to your installation of uMod and locate uMod.dll. Copy it and paste it next to the freshly compiled uModPatcher.exe.
 2. Navigate to .opj for the target game and open it in a plain text editor. It is formatted as a JSON file.
 3. Find the "TargetDirectory" field in the json text and change the value to be the "Managed" folder of your target game server installation.
 4. Launch the patcher. Go to File -> Open Project, and open the .opj.
 5. If all goes well, the hooks and assembly list should appear on the tree view to the left.
 6. To patch, click the wand icon on the toolbar.
 7. To add a hook, navigate to the desired method from the desired assembly and click the "Hook this Method" button.
 8. To include more assemblies, right click on any red-cross assembly and select "Add to Project".

## Notes

 * You should work on a "vanilla" version of the target game.
 * The patcher will make copies of the original DLLs and append "_Original" to them, and it will use them as the input when patching. This means it's safe to make a few changes and patch over and over again.
