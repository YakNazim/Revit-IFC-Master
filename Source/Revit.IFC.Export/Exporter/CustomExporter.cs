using Autodesk.Revit.UI;
using Revit.IFC.Common.Enums;
using Revit.IFC.Export.Exporter.PropertySet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
 * Add this bit of code to the methods in case of ifc4 export 
***/
//if (ExporterCacheManager.ExportOptionsCache.ExportAs4)
//{
//    propertySetManufacturer.AddEntry(PropertySetEntry.CreateIdentifier("GlobalTradeItemNumber"));
//    propertySetManufacturer.AddEntry(PropertySetEntry.CreateEnumeratedValue("AssemblyPlace",
//    PropertyType.Label,
//    typeof(Toolkit.IFC4.PsetManufacturerTypeInformation_AssemblyPlace)));
//}


namespace Revit.IFC.Export.Exporter
{
    class CustomExporter
    {
        public static void InitCustomPropertySet(IList<IList<PropertySetDescription>> propertySets)
        {
            IList<PropertySetDescription> commonPropertySets = new List<PropertySetDescription>();

            // call the routines here
            //Init_Pset_Evac4BIM(commonPropertySets);
            Init_Pset_SpaceOccupancyRequirements(commonPropertySets);
            Init_Pset_SpaceFireSafetyRequirements(commonPropertySets);
            Init_Pset_SimulationID(commonPropertySets);
            Init_Pset_SpaceEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingCommon(commonPropertySets);
            Init_Pset_DoorCommon(commonPropertySets);
            Init_Pset_DoorEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingOccupancyRequirements(commonPropertySets);
            Init_Pset_SpaceCommon(commonPropertySets);
            Init_Pset_StairCommon(commonPropertySets);
            Init_Pset_StairEgressPerformanceInformation(commonPropertySets);


            // Append the propertySets list
            propertySets.Add(commonPropertySets);

            TaskDialog.Show("Success", "Export completed succesfuly ! ");

        }

        public static void Init_Pset_SpaceOccupancyRequirements(IList<PropertySetDescription> commonPropertySets)
        {

           PropertySetEntry ifcPSE = null;

           PropertySetDescription propertySet = new PropertySetDescription();
           propertySet.Name = "Pset_SpaceOccupancyRequirements";
           propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);


            /*
            // These properties are handled by default in Revit Export 

            ifcPSE = new PropertySetEntry("OccupancyNumber");
            ifcPSE.PropertyName = "OccupancyNumber";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AreaPerOccupant");
            ifcPSE.PropertyName = "AreaPerOccupant";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyNumberPeak");
            ifcPSE.PropertyName = "AreaPerOccupant";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

             */



            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);                
            }

        }

        public static void Init_Pset_SpaceFireSafetyRequirements(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceFireSafetyRequirements";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);

            ifcPSE = new PropertySetEntry("DetectionAlarmTime");
            ifcPSE.PropertyName = "DetectionAlarmTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }
        }


        public static void Init_Pset_SimulationID(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SimulationID";
            propertySet.EntityTypes.Add(IFCEntityType.IfcProject);


            ifcPSE = new PropertySetEntry("SoftwareName");
            ifcPSE.PropertyName = "SoftwareName";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("SoftwareVersion");
            ifcPSE.PropertyName = "SoftwareVersion";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("SoftwareVendor");
            ifcPSE.PropertyName = "SoftwareVendor";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("SimulationSummary");
            ifcPSE.PropertyName = "SimulationSummary";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);





            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_SpaceEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);
                                   
 
            


            ifcPSE = new PropertySetEntry("RSET");
            ifcPSE.PropertyName = "RSET";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("InitialOccupantNumber");
            ifcPSE.PropertyName = "InitialOccupantNumber";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("occupantCountHistory");
            ifcPSE.PropertyName = "occupantCountHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);                
            }

        }

        public static void Init_Pset_BuildingEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);
              

            ifcPSE = new PropertySetEntry("MinWalkDistance");
            ifcPSE.PropertyName = "MinWalkDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("MaxWalkDistance");
            ifcPSE.PropertyName = "MaxWalkDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AvgWalkDistance");
            ifcPSE.PropertyName = "AvgWalkDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("TotalRSET");
            ifcPSE.PropertyName = "TotalRSET";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AvgExitTime");
            ifcPSE.PropertyName = "AvgExitTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("MinExitTime");
            ifcPSE.PropertyName = "MinExitTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("TotalOccupantCountHistory");
            ifcPSE.PropertyName = "TotalOccupantCountHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }



        public static void Init_Pset_BuildingCommon(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);


            ifcPSE = new PropertySetEntry("OccupancyDistributionDayNight");
            ifcPSE.PropertyName = "OccupancyDistributionDayNight";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }


        public static void Init_Pset_DoorCommon(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_DoorCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcDoor);


            ifcPSE = new PropertySetEntry("isNormalyClosed");
            ifcPSE.PropertyName = "isNormalyClosed";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("doorFlowrate");
            ifcPSE.PropertyName = "doorFlowrate";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }



        public static void Init_Pset_DoorEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_DoorEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcDoor);


            ifcPSE = new PropertySetEntry("FirstIn");
            ifcPSE.PropertyName = "FirstIn";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("LastOut");
            ifcPSE.PropertyName = "LastOut";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("FlowAvg");
            ifcPSE.PropertyName = "FlowAvg";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("TotalUse");
            ifcPSE.PropertyName = "TotalUse";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("doorFlowHistory");
            ifcPSE.PropertyName = "doorFlowHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);
            

            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }


        }

        public static void Init_Pset_BuildingOccupancyRequirements(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingOccupancyRequirements";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);

            ifcPSE = new PropertySetEntry("ReacTime");
            ifcPSE.PropertyName = "ReacTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            // Occupant profiles 
            ifcPSE = new PropertySetEntry("occupantProfile1");
            ifcPSE.PropertyName = "occupantProfile1";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("occupantProfile2");
            ifcPSE.PropertyName = "occupantProfile2";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("occupantProfile3");
            ifcPSE.PropertyName = "occupantProfile3";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("occupantProfile4");
            ifcPSE.PropertyName = "occupantProfile4";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("occupantProfile5");
            ifcPSE.PropertyName = "occupantProfile5";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }
        }

        

        public static void Init_Pset_SpaceCommon(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);

                         

            ifcPSE = new PropertySetEntry("AdmittedProfiles");
            ifcPSE.PropertyName = "AdmittedProfiles";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            
            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_StairCommon(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_StairCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcStair);



            ifcPSE = new PropertySetEntry("AdmittedProfiles");
            ifcPSE.PropertyName = "AdmittedProfiles";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_StairEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_StairEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcStair);



            ifcPSE = new PropertySetEntry("FirstIn");
            ifcPSE.PropertyName = "FirstIn";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("LastOut");
            ifcPSE.PropertyName = "LastOut";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("FlowAvg");
            ifcPSE.PropertyName = "FlowAvg";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("occupantCountHistory");
            ifcPSE.PropertyName = "occupantCountHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }


        

    }
}
