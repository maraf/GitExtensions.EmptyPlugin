# GitExtensions.EmptyPlugin
An example/empty repository for building a GitExtensions plugin that can be installed using [GitExtensions.PluginManager](https://github.com/maraf/GitExtensions.PluginManager).

The package published to [NuGet.org](https://www.nuget.org/packages/GitExtensions.EmptyPlugin) feed.

## Files to keep an eye on
 - [Plugin.cs](src/GitExtensions.EmptyPlugin/Plugin.cs)
 - [GitExtensions.EmptyPlugin.csproj](src/GitExtensions.EmptyPlugin/GitExtensions.EmptyPlugin.csproj)
 - [GitExtensions.EmptyPlugin.nuspec](src/GitExtensions.EmptyPlugin/GitExtensions.EmptyPlugin.nuspec)
 
### Nuspec
 - Place all content under lib folder. Custom nested folders are supported and path is preserved.
 - Add dependency on "virtual" package GitExtensions.Plugins and target version `[3.0,3.1)` *.
 - Real package dependencies are not supported, so everything should be packed with the plugin.
 - Keep in mind that sharing common libraries can be cumbersome as these must match across all plugins and also Git Extensions itself. So my current recommendation is not to do so.
 
_* This is just my own eperience. Git Extensions follow SemVer, but it's public plugin API is not so rich that sometimes you need to kind a hack it using APIs that are not ment to be public. For these reasons its better to check compatibility with every single feature update._

### Csproj

 - I'm using powershell script to download a selected version of Git Extensions from GitHub releases. This script runs before every build and checks if Git Extensions binaries are donwloaded.
 - CSproj references selected binaries from the downloaded Git Extensions.
 - After build a newly created binaries of the plugin is copied to Git Extensions plugins directory.
 - F5 is setup to start downloaded `GitExtensions.exe` for easy debugging.
 
 ### Plugin.cs
  - Nothing special, but ordinary Git Extensions plugin :-)

## Icons

Some icons by Yusuke [Kamiyamane](http://p.yusukekamiyamane.com).
