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

/// <summary>
/// This class defines a method - used as a delegate - to process custom PSets
/// </summary>

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

            TaskDialog.Show("Success", "Custom exporter initiated ! ");

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

            ifcPSE = new PropertySetEntry("AlarmTime");
            ifcPSE.PropertyName = "AlarmTime";
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


            ifcPSE = new PropertySetEntry("EvacuationModelName");
            ifcPSE.PropertyName = "EvacuationModelName";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("EvacuationModelVersion");
            ifcPSE.PropertyName = "EvacuationModelVersion";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EvacuationModelVendor");
            ifcPSE.PropertyName = "EvacuationModelVendor";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EvacuationSimulationBrief");
            ifcPSE.PropertyName = "EvacuationSimulationBrief";
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
                                   
 
            ifcPSE = new PropertySetEntry("EvacuationTime");
            ifcPSE.PropertyName = "EvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("InitialOccupancyNumber");
            ifcPSE.PropertyName = "InitialOccupancyNumber";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyHistory");
            ifcPSE.PropertyName = "OccupancyHistory";
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
              

            ifcPSE = new PropertySetEntry("MinTravelDistance");
            ifcPSE.PropertyName = "MinTravelDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("MaxTravelDistance");
            ifcPSE.PropertyName = "MaxTravelDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AverageTravelDistance");
            ifcPSE.PropertyName = "AverageTravelDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EvacuationTimeOverall");
            ifcPSE.PropertyName = "EvacuationTimeOverall";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AverageEvacuationTime");
            ifcPSE.PropertyName = "AverageEvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("MinEvacuationTime");
            ifcPSE.PropertyName = "MinEvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("OccupancyHistoryOverall");
            ifcPSE.PropertyName = "OccupancyHistoryOverall";
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


            ifcPSE = new PropertySetEntry("isAccessible");
            ifcPSE.PropertyName = "isAccessible";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("RequiredDoorFlowrate");
            ifcPSE.PropertyName = "RequiredDoorFlowrate";
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


            ifcPSE = new PropertySetEntry("FirstOccupantInTime");
            ifcPSE.PropertyName = "FirstOccupantInTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("LastOccupantOutTime");
            ifcPSE.PropertyName = "LastOccupantOutTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("AverageOccupantFlowrate");
            ifcPSE.PropertyName = "AverageOccupantFlowrate";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("TotalUse");
            ifcPSE.PropertyName = "TotalUse";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("DoorFlowrateHistory");
            ifcPSE.PropertyName = "DoorFlowrateHistory";
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

            ifcPSE = new PropertySetEntry("PreEvacuationTime");
            ifcPSE.PropertyName = "PreEvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            // Occupant profiles 
            ifcPSE = new PropertySetEntry("OccupantProfilesList");
            ifcPSE.PropertyName = "OccupantProfilesList";
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



            ifcPSE = new PropertySetEntry("FirstOccupantInTime");
            ifcPSE.PropertyName = "FirstOccupantInTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("LastOccupantOutTime");
            ifcPSE.PropertyName = "LastOccupantOutTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AverageOccupantFlowrate");
            ifcPSE.PropertyName = "AverageOccupantFlowrate";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyHistory");
            ifcPSE.PropertyName = "OccupancyHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }


        

    }
}
