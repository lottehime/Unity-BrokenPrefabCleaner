# Unity Broken Prefab Cleaner
Small script thast finds prefabs that are now missing a certain component (broken) and deletes them.

---

### Did you purposefully delete some objects from the project that were parts of some prefabs, and now those prefabs are broken junk you need to clean up?

### Are there over 9000 items and you don't want to find and delete them by hand?

### Use this.

---

## How to use:

1. Place it in your project.
2. Edit MenuItem to specify where the menu item lives (if you don't like the default).
3. Edit the path string in objGUIDs definition to the folder you want to clean prefabs up in.
4. Edit the compType string definition to the type that you want to check is missing from the prefabs (be aware, you may need to specify UnityEngine.Type for some Unity types).
5. Save it, run it.
6. Wait.
7. Prefabs cleaned up.

### Just be sure you're directing it to the right location or have a bad day.

---

## Usage example for context:

I have 900 meshes each turned into 4 prefabs each (with a different shader per), stored in multiple folders.

I prune 700 meshes out of the project. They aren't needed anymore.

Now I have 200 prefabs I want, and 700 that are broken junk and I want to delete them all from their subsequent folders.

They will no longer have a MeshRenderer component attached to them as the mesh no longer exists. We can target them based on that.

Edit script, run it. Wait. Go make a coffee. Come back. Prefabs gone!
