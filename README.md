## what is this?

for testing `T1574.014`: `Hijack Execution Flow: AppDomainManager`

Launcher.exe runs, then because of it's config file, ClassLibrary1.dll (evil) is loaded

TODO:
 - [ ] add a version that attempts a network connection
 - [ ] test with and without `<etwEnable enabled="false" />` in the config file

