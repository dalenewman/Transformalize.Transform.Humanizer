nuget pack Transformalize.Transform.Humanizer.Autofac.nuspec -OutputDirectory "c:\temp\modules"
nuget pack Transformalize.Transform.Humanizer.nuspec -OutputDirectory "c:\temp\modules"
 
nuget push "c:\temp\modules\Transformalize.Transform.Humanizer.0.8.1-beta.nupkg" -source https://www.myget.org/F/transformalize/api/v3/index.json
nuget push "c:\temp\modules\Transformalize.Transform.Humanizer.Autofac.0.8.1-beta.nupkg" -source https://www.myget.org/F/transformalize/api/v3/index.json
