# Introduction #
I (Donno) will try to explain how the core of the editor should/will work once I get around to it. I have limited intrest in working on this.

# Details #
The general idea is a a 'IDE' that like Visual Studio, maybe in the future someone could be motivated enought just to make the editor as a plugin for Eclipse (that way its truly platform independant. and is ontop of a platform that can also edit C/C++/Python/java etc.


**View**
  * Output Window
  * File Browser (Shows the files in the current skin path)
  * Skin Browser (Shows the Windows and Includes of the current skin)

# View #
## Output Window ##
Messages about loading etc standard logging style stuff.

## Skin/File Browser ##
Will show you which files/window files are open (being edited), another indicated one which files have been modified.
At the time of writting XBMC only supports 1 Window decarled/defined per file

# Skin #
When a skin is loaded, all the file names for each resolution will be loaded in and a place for the xml document for that file to be stored as well as weather hte file is open, and modfied. With a way to save and load. So bascially when you edit a skin ur editing the xml dom (or whatever of that). Will cleanup this section once I (Donno) implement it. The base unit for this is currently called SkinComponent.

# Plugins #
The Editor will support plugins, more on this later.

# SkinComponent #
**Protected Varibles**
  * string mFileName
  * XmlDocument mComponentDoc
  * bool mIsOpen
  * bool mIsModified
**Public Methods**
  * Read()
  * Save() - Saves the mComponentDoc (XmlDocument) to mFileName. (IsModfied = false)
  * bool mIsOpen
  * bool mIsModified
**Public Properties**
  * IsOpen [only](get.md)
  * IsModifed [only](get.md)
  * Filename

Please Note this is prelim, im only putting it here to hold my thoughts, and partials snippets of the current state of the code.