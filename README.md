This adds several methods to Transformalize using [Humanizer](https://github.com/Humanizr/Humanizer).  It is a plug-in compatible with Transformalize 0.2.11-beta.

Build the Autofac project and put it's output into Transformalize's *plugins* folder.

Use like this:

```xml
<cfg name="Test">
    <connections>
        <add name="input" provider="internal" />
        <add name="output" provider="console" />
    </connections>
    <entities>
        <add name="Test">
            <rows>
                <add id="1" input-sql="select * from customers where name = 'google';" />
            </rows>
            <fields>
                <add name="id" type="int" />
                <add name="input-sql" length="4000" />
            </fields>
            <calculated-fields>
                <add name="output-sql" length="4000" t="copy(input-sql).formatsql()" />
            </calculated-fields>
        </add>
    </entities>
</cfg>
```