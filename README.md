# Revit-IFC-Master
A fork of the open source Revit IFC exporter. It allows to generate enriched IFC files supporting the fire evacuation data requirements of the draft FSE MVD.

This add-in was developed as part of a master thesis and in partial fulfilment of the requirements for the degree of The International Master of Science in Fire Safety Engineering (IMFSE). The full text of thesis will be published shortly.

## Acknowledgments
IFC for Revit and Navisworks (revit-ifc) by Autodesk [(available on Github)](https://github.com/Autodesk/revit-ifc)

## Installation Instructions 
- The assemblies are released along with the Evac4Bim Revit add-in [here](https://github.com/YakNazim/Evac4Bim/releases)
- Installation instructions are given [here](https://github.com/YakNazim/Evac4Bim#installation-instructions)

## Build Instructions 
- Clone/download the repository. 
- Open the project solution in Visual Studio
The solution and its sub projects are already configured but ensure your local environment meets the following requirements before attempting to build: 

>   - .NET FRAMEWORK version 4.8 in Visual Studio
>
>   - A local installation of Autodesk Revit (since the solution references several dll files from it) 
>
>   - In the project solution, ensure the path to each referenced dll is correct (do this for every sub project)
>
>![Capture d’écran 2022-04-16 162949](https://user-images.githubusercontent.com/17513670/163678998-a78af818-25ef-409e-8a3d-ca9640ff2a17.png)
>
>   - If the target path does not match the local installation folder of Revit, you can add the reference manually and overwrite the previous one.   
>
>![Picture1](https://user-images.githubusercontent.com/17513670/163679735-1c87aed4-0099-4167-a219-0dc156930e13.png)
>
>   - In addition to that, you need to install the following dependencies from NuGet
>
>![image](https://user-images.githubusercontent.com/17513670/163692337-ca7f5f55-6fe6-48d7-911a-614d89421fe6.png)
>
- Once you setup the environment, build the solution 
- To deploy the solution, copy the assemblies into Revit's addin folder e.g C:\ProgramData\Autodesk\Revit\Addins\2022

**Note 1** : the project solution is configured to autmatically copy the assemblies and dependencies into the add-in folder as a "post-build" event. You can adjust the path to the folder in project properties or disable the post-build event. 

**Note 2** : In any case, you have to follow the same folder structure as the installation package provided in the release (see above). 

**Note 3** : Do not forget to add manifest files (.addin). You can use the manifest files included in the installation package of the release.

**Note 4** : Do not forget to add the assembly dlls for the dependecies (please refer to the installation package of the release - see above).

## Code reference
An overview of the code is given in [this wiki](https://github.com/YakNazim/Evac4Bim/wiki/Code-reference)
