# Sematime Glue

A C# DLL to allow users to interact with the sematime API

The DLL exploits version 4 of the [Sematime API](http://sematime.com/).

This DLL works with any .NET Framework languages

[For more information see the wiki](https://github.com/mwangepatrick/sematime-glue/wiki)

### Install Sematime Glue

If you want to include Sematime Glue in your project, you can clone the project and build the latest copy the import then import the DLL on your end or you can also add the project as an extension to your main project.
To install ClosedXML, run the following command in the Package Manager Console

### What can you do with this?

With Sematime Glue, Currently, you can only send messages using the sematime API. 

```c#
var sematimeGlue = new SematimeGlue()
```

## Minimum Requirements

To run Sematime Glue, you need:
1. .Net Framework version >= 4.5.2
