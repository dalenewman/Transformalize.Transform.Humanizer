nuget pack Transformalize.Transform.Humanizer.Autofac.nuspec -OutputDirectory "c:\temp\modules"
nuget pack Transformalize.Transform.Humanizer.nuspec -OutputDirectory "c:\temp\modules"
REM 
REM nuget push "c:\temp\modules\Transformalize.Transform.Humanizer.0.6.6-beta.nupkg" -source https://api.nuget.org/v3/index.json
REM nuget push "c:\temp\modules\Transformalize.Transform.Humanizer.Autofac.0.6.6-beta.nupkg" -source https://api.nuget.org/v3/index.json
